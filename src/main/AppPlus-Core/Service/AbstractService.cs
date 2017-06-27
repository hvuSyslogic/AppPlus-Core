using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;
using System.Transactions;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.ServiceModel;
using System.Runtime.Serialization;
using Microsoft.Practices.Unity;
using log4net;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using Serialize.Linq.Serializers;
using AppPlus.Infrastructure.Contract.Messages;
using AppPlus.Infrastructure.Contract.Services;
using AppPlus.Core.Common.CodeContracts;
using AppPlus.Infrastructure.Configuration;
using AppPlus.Core.EntityFramework;

namespace AppPlus.Core.Service
{
    [GlobalExceptionHandlerBehaviourAttribute(typeof(GlobalExceptionHandler))]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public abstract class AbstractService<TEntity, TDTO, TKey> : ServiceRoot, IGenericService<TDTO, TKey>
        where TEntity : EntityBase<TKey>, new()
        where TDTO : DtoBase<TKey>, new()
        where TKey : struct
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool _disposed = false;

        #region Automapper configuration        
        protected override void ConfigureMap()
        {
            CreateMap<TEntity, TDTO>().ReverseMap();
        }
        #endregion

        #region Create
        public virtual TDTO Create(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Create<TEntity>(entity);
                });

                return entity.MapTo<TDTO>();
            }
        }

        public virtual IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Create(entities);
                });
            }

            return entities.MapTo<TDTO>();
        }
        #endregion
        
        #region how to determine whether a Type is a number
        // Taking Guillaume's solution a little further
        // https://stackoverflow.com/questions/1749966/c-sharp-how-to-determine-whether-a-type-is-a-number
        // https://stackoverflow.com/questions/1749966/c-sharp-how-to-determine-whether-a-type-is-a-number/1750093#1750093
        //public static bool IsNumeric(object expression)
        //{
        //    if (expression == null)
        //        return false;

        //    double number;
        //    return Double.TryParse(Convert.ToString(expression, CultureInfo.InvariantCulture), System.Globalization.NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);
        //}

        //public static bool IsNumericType(this object o)
        //{
        //    switch (Type.GetTypeCode(o.GetType()))
        //    {
        //        case TypeCode.Byte:
        //        case TypeCode.SByte:
        //        case TypeCode.UInt16:
        //        case TypeCode.UInt32:
        //        case TypeCode.UInt64:
        //        case TypeCode.Int16:
        //        case TypeCode.Int32:
        //        case TypeCode.Int64:
        //        case TypeCode.Decimal:
        //        case TypeCode.Double:
        //        case TypeCode.Single:
        //            return true;
        //        default:
        //            return false;
        //    }
        //}
        #endregion

        #region Retrieve
        public virtual TDTO RetrieveById(TKey id)
        {
            long result;
            long.TryParse(id.ToString(), out result);
            Requires.InRange(result > 0, "id");
            
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    var entity = uow.Retrieve<TEntity>(id);

                    return entity.MapTo<TDTO>();
                });
            }
        }

        public virtual IEnumerable<TDTO> Retrieve(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");
            
            var expression = predicateExpressionNode.ToBooleanExpression<TDTO>();

            var predicateExpression = Mapper.Map<Expression<Func<TEntity, bool>>>(expression);

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    var entities = uow.Retrieve<TEntity>(predicateExpression);

                    return entities.MapTo<TDTO>();
                });
            }
        }

        public virtual IEnumerable<TDTO> RetrieveAll()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    var entities = uow.Retrieve<TEntity>();

                    return entities.MapTo<TDTO>();
                });
            }
        }
        #endregion

        #region Update
        public virtual void Update(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Update<TEntity>(entity);
                });
            }
        }

        public virtual void Update(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Update(entities);
                });
            }
        }

        //public int Update<TEntity>(Expression<Func<TEntity, TEntity>> updateExpression,
        //    Expression<Func<TEntity, bool>> predicate = null)
        //    where TEntity : EntityBase, new()
        //{

        //}
        #endregion

        #region Delete
        public virtual void DeleteById(TKey id)
        {
            long result;
            long.TryParse(id.ToString(), out result);
            Requires.InRange(result > 0, "id");

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Delete<TEntity>(id);
                });
            }
        }

        public virtual void Delete(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Delete<TEntity>(entity);
                });
            }
        }

        public virtual void Delete(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Delete(entities);
                });
            }
        }

        public virtual int Delete(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicateExpression = (predicateExpressionNode == null)
                ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Delete<TEntity>(predicateExpression);
                });
            }
        }

        public virtual int DeleteAll()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Delete<TEntity>();
                });
            }
        }
        #endregion

        #region Count

        public virtual int Count()
        {
            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Count<TEntity>();
                });
            }
        }

        public virtual int Count(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Count<TEntity>(predicate);
                });
            }
        }
        #endregion

        #region Contains

        public virtual bool Contains(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Retrieve<TEntity>(dto.Id) != null;
                });
            }
        }

        public virtual bool Contains(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Contains(predicate);
                });
            }
        }

        #endregion

        #region Filter

        public virtual IEnumerable<TDTO> Filter(ExpressionNode predicateExpressionNode, int pageNumber = 0, int pageSize = 50)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = (predicateExpressionNode == null)
                   ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            using (var command = CommandWrapper)
            {
                return command.Execute(uow =>
                {
                    return uow.Filter(predicate, pageNumber, pageSize).Item1.MapTo<TDTO>();
                });
            }
        }

        #endregion

        #region CreateOrUpdate

        public virtual Tuple<Int32, Int32> CreateOrUpdate(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var addedEntityCollection = dtos.Where(x => x.Id.Equals(0)).MapTo<TEntity>();
            var modifiedEntityCollection = dtos.Where(x => !x.Id.Equals(0)).MapTo<TEntity>();

            using (var command = CommandWrapper)
            {
                command.Execute(uow =>
                {
                    uow.Create(addedEntityCollection);
                    uow.Update(modifiedEntityCollection);
                }, new UnitOfWorkSettings() { TransactionScope = TransactionOption.DBTransaction });

                return new Tuple<int, int>(addedEntityCollection.Count(), modifiedEntityCollection.Count());
            }
        }

        #endregion

        //#region ExecuteDataSet

        //protected virtual DataSet ExecuteDataSet(string cmdText, DbParameter[] parameters, CommandType commandType)
        //{
        //    using (var command = CommandWrapper)
        //    {
        //        return command.Execute(uow =>
        //        {
        //            return uow.ExecuteDataSet(cmdText, parameters, commandType);
        //        });
        //    }
        //}

        //protected virtual DataTable ExecuteDataTable(string cmdText, DbParameter[] parameters, CommandType commandType)
        //{
        //    using (var command = CommandWrapper)
        //    {
        //        return command.Execute(uow =>
        //        {
        //            return uow.ExecuteDataTable(cmdText, parameters, commandType);
        //        });
        //    }
        //}

        //#endregion

        //#region Dispose

        //public void Dispose()
        //{
        //    Log.Error("abstract service Dispose()");
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //protected virtual void Dispose(bool disposing)
        //{
        //    Log.Error("abstract service Dispose(bool)");
        //    if (!this._disposed)
        //    {
        //        if (disposing)
        //        {
        //            if (CommandWrapper != null)
        //            {
        //                CommandWrapper.Dispose();
        //            }
        //        }
        //    }

        //    this._disposed = true;
        //}

        //#endregion
    }
}