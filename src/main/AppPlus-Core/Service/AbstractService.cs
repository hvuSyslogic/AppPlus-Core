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
using AppPlus.Infrastructure.Configuration;
using AppPlus.Core.EntityFramework;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using AppPlus.Core.Infrastructure.CodeContracts;
using System.ServiceModel.Web;

namespace AppPlus.Core.Service
{
    [GlobalErrorBehaviorAttribute(typeof(GlobalErrorHandler))]
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public abstract class AbstractService<TEntity, TDTO, TKey> : ServiceRoot, IGenericService<TDTO, TKey>
        where TEntity : EntityBase<TKey>, new()
        where TDTO : DtoBase<TKey>, new()
        where TKey : struct
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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

            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Create(entity).MapTo<TDTO>();
            });
        }

        public virtual IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Create(entities).MapTo<TDTO>();
            });
        }
        #endregion              

        #region Retrieve
        public virtual TDTO RetrieveById(TKey id)
        {
            long result;
            long.TryParse(id.ToString(), out result);
            Requires.InRange(result > 0, "id");

            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Retrieve(id).MapTo<TDTO>();
            });
        }
        
        public virtual IEnumerable<TDTO> Retrieve(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");
            
            var expression = predicateExpressionNode.ToBooleanExpression<TDTO>();

            var predicateExpression = Mapper.Map<Expression<Func<TEntity, bool>>>(expression);

            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Retrieve(predicateExpression).MapTo<TDTO>();
            });
        }
        
        public virtual IEnumerable<TDTO> RetrieveAll()
        {
            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Retrieve().MapTo<TDTO>();
            });
        }
        #endregion

        #region Update
        public virtual void Update(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();           

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Update(entity);
            });
        }

        public virtual void Update(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Update(entities);
            });
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

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Delete(id);
            });
        }

        public virtual void Delete(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();         

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Delete(entity);
            });
        }

        public virtual void Delete(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();
            
            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Delete(entities);
            });
        }

        public virtual int Delete(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicateExpression = (predicateExpressionNode == null)
                ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Delete(predicateExpression);
            });
        }

        public virtual int DeleteAll()
        {
            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Delete();
            });
        }
        #endregion

        #region Count

        public virtual int Count()
        {
            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Count();
            });
        }

        public virtual int Count(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());
            
            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Count(predicate);
            });
        }
        #endregion

        #region Contains

        public virtual bool Contains(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            TKey id = dto.Id;

            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Retrieve(id) != null;
            });
        }

        public virtual bool Contains(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());
            
            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().Contains(predicate);
            });
        }

        #endregion

        #region Filter

        public virtual IEnumerable<TDTO> Filter(out int totalPages, int pageNumber = 0, int pageSize = 50)
        {
            return Filter(out totalPages, null, pageNumber, pageSize);
        }

        //public virtual IEnumerable<TDTO> Filter(Func<IQueryable<TDTO>,
        //    IOrderedQueryable<TDTO>> orderBy, int pageNumber = 0, int pageSize = 50)
        //{
        //    return Filter(null, orderBy, pageNumber, pageSize);
        //}

        public virtual IEnumerable<TDTO> Filter(out int totalPages, ExpressionNode predicateExpressionNode, int pageNumber = 0, int pageSize = 50)
        {
            //Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = (predicateExpressionNode == null)
                   ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            int pages = 0;

            var result = UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Filter(predicate, null, out pages, pageNumber, pageSize).MapTo<TDTO>();
            });

            totalPages = pages;

            return result;
        }

        #endregion

        //#region CreateOrUpdate

        //public virtual Tuple<Int32, Int32> CreateOrUpdate(IEnumerable<TDTO> dtos)
        //{
        //    Requires.NotNullOrEmpty(dtos, "dtos");

        //    var addedEntityCollection = dtos.Where(x => x.Id.Equals(0)).MapTo<TEntity>();
        //    var modifiedEntityCollection = dtos.Where(x => !x.Id.Equals(0)).MapTo<TEntity>();

        //    return UnitOfWork.Do(uow => 
        //    {
        //        uow.Repo<TEntity>().Create(addedEntityCollection);
        //        uow.Repo<TEntity>().Update(modifiedEntityCollection);

        //        return new Tuple<int, int>(addedEntityCollection.Count(), modifiedEntityCollection.Count());
        //    });
        //}

        //#endregion

        #region ExecuteDataTable      

        #endregion

        #region ExecuteDataSet
        protected virtual DataTable GetDataTableByStoredProc(string commandText, DbParameter[] parameters, string tableName = "")
        {
            DataSet ds = this.GetDataSet(commandText, CommandType.StoredProcedure, parameters);
            DataTable dt = ds.Tables[0];

            if (string.IsNullOrWhiteSpace(tableName))
            {
                dt.TableName = tableName;
            }

            return dt;
        }

        protected virtual DataTable GetDataTableBySql(string commandText, DbParameter[] parameters, string tableName)
        {
            DataSet ds = this.GetDataSet(commandText, CommandType.Text, parameters);
            DataTable dt = ds.Tables[0];
            if (string.IsNullOrWhiteSpace(tableName))
            {
                dt.TableName = tableName;
            }
            
            return dt;
        }

        private DataSet GetDataSet(string commandText, CommandType commandType, DbParameter[] parameters)
        {
            DataSet ds = new DataSet();

            return UnitOfWork.Do(uow => 
            {
                EntityConnection entityConnection = (EntityConnection)uow.Session.Database.Connection;

                SqlConnection connection = (SqlConnection)entityConnection.StoreConnection;
                SqlCommand command = new SqlCommand(commandText, connection);

                using (command)
                {
                    command.CommandType = commandType;
                 
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            if (parameter != null)
                            {
                                if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                                    (parameter.Value == null))
                                {
                                    parameter.Value = DBNull.Value;
                                }

                                command.Parameters.Add(parameter);
                            }
                        }
                    }

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

                    sqlDataAdapter.Fill(ds);

                    return ds;
                }
            });
        }

        #endregion
    }
}