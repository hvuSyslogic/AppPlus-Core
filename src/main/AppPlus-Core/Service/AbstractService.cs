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
    public abstract class AbstractService<TEntity, TDTO, TKey> : Profile, IGenericService<TDTO, TKey>
        where TEntity : EntityBase<TKey>, new()
        where TDTO : DtoBase<TKey>, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool _disposed = false;
        
        #region Properties
        [Dependency]
        protected virtual ICommandWrapper CommandWrapper
        {
            get { return AppConfigurator.Container.Resolve<ICommandWrapper>(); }
        }
        #endregion

        #region Automapper configuration
        [Obsolete]
        protected override void Configure()
        {
            CreateMap<TEntity, TDTO>().ReverseMap();
        }
        #endregion

        #region Create
        public virtual TDTO Create(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();
                        
            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Create(entity);                
            });

            return entity.MapTo<TDTO>();
        }

        public virtual IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Create(entities);
            });
            
            return entities.MapTo<TDTO>();
        }
        #endregion

        #region Retrieve
        public virtual TDTO RetrieveById(object id)
        {
            Requires.NotNull(id, "id");

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
        public virtual void DeleteById(object id)
        {
            Requires.NotNull(id, "id");

            UnitOfWork.Do(uow => 
            {
                uow.Repo<TEntity>().Delete(id);
            });
        }

        public virtual bool Delete(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            var entity = dto.MapTo<TEntity>();
          
            UnitOfWork.Do(uow =>
            {
                uow.Repo<TEntity>().Delete(entity);
            });

            return true;
        }

        public virtual int Delete(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().Delete(entities).Count();
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
                return uow.Repo<TEntity>().Count(null);
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
            
            //TODO:

            //using (var command = CommandWrapper)
            //{
            //    return command.Execute(uow =>
            //    {
            //        return uow.Retrieve<TEntity>(dto.Id) != null;
            //    });
            //}

            return true;
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

        public virtual IEnumerable<TDTO> Filter(ExpressionNode predicateExpressionNode, int index = 0, int size = 50)
        {
            //Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            //var predicate = (predicateExpressionNode == null)
            //       ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());           

            //return UnitOfWork.Do(uow => 
            //{
            //    uow.Repo<TEntity>().Filter(predicate, index, size).Item1.MapTo<TDTO>();
            //});
            throw new NotImplementedException();
        }

        #endregion

        #region CreateOrUpdate

        public virtual Tuple<Int32, Int32> CreateOrUpdate(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            //TODO:
            //var addedEntityCollection = dtos.Where(x => x.Id.Equals(0)).MapTo<TEntity>();
            //var modifiedEntityCollection = dtos.Where(x => !x.Id.Equals(0)).MapTo<TEntity>();

            //using (var command = CommandWrapper)
            //{
            //    command.Execute(uow =>
            //    {
            //        uow.Create(addedEntityCollection);
            //        uow.Update(modifiedEntityCollection);
            //    }, new UnitOfWorkSettings() { TransactionScope = TransactionOption.DBTransaction });

            //    return new Tuple<int, int>(addedEntityCollection.Count(), modifiedEntityCollection.Count());
            //}

            return new Tuple<int, int>(1, 1);
        }

        #endregion      

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (CommandWrapper != null)
                    {
                        CommandWrapper.Dispose();
                    }
                }
            }

            this._disposed = true;
        }

        #endregion
    }
}