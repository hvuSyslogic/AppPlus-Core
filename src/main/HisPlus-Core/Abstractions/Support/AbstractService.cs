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
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using Serialize.Linq.Serializers;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Infrastructure.CodeContracts;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Core.Abstractions.Support
{    
    public abstract class AbstractService<TEntity, TDTO, TKey> : ServiceRoot, IGenericService<TDTO, TKey>
        where TEntity : EntityBase<TKey>, new()
        where TDTO : DtoBase<TKey>, new()
        where TKey : struct
    {
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

            UnitOfWork.Do(uow => 
            {
                entity = uow.Repo<TEntity>().Create(entity);                
            });

            return entity.MapTo<TDTO>();
        }

        public virtual IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos)
        {
            Requires.NotNullOrEmpty(dtos, "dtos");

            var entities = dtos.MapTo<TEntity>();

            UnitOfWork.Do(uow => 
            {
                entities = uow.Repo<TEntity>().Create(entities);                
            });

            return entities.MapTo<TDTO>();
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

        public virtual long Count()
        {
            return UnitOfWork.Do(uow => 
            {
                return uow.Repo<TEntity>().LongCount();
            });
        }

        public virtual long Count(ExpressionNode predicateExpressionNode)
        {
            Requires.NotNull(predicateExpressionNode, "predicateExpressionNode");

            var predicate = Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());
            
            return UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().LongCount(predicate);
            });
        }
        #endregion        

        #region Contains

        public virtual bool Contains(TKey id)
        {
            return UnitOfWork.Do(uow =>
            {
                var entity = uow.Repo<TEntity>().Retrieve(id);

                return (entity != null);
            });
        }

        public virtual bool Contains(TDTO dto)
        {
            Requires.NotNull(dto, "dto");

            TKey id = dto.Id;

            return Contains(id);
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

        #region RetrievePagedData

        public virtual IEnumerable<TDTO> RetrievePagedData(int pageNumber, int pageSize, out int pageCount)
        {
            return RetrievePagedData(null, pageNumber, pageSize, out pageCount);
        }

        public virtual IEnumerable<TDTO> RetrievePagedData(ExpressionNode predicateExpressionNode, int pageNumber, int pageSize, out int pageCount)
        {
            var predicate = (predicateExpressionNode == null)
                   ? null : Mapper.Map<Expression<Func<TEntity, bool>>>(predicateExpressionNode.ToBooleanExpression<TDTO>());

            int totalPages = 0;

            var result = UnitOfWork.Do(uow =>
            {
                return uow.Repo<TEntity>().RetrievePagedData(predicate, null, pageNumber, pageSize, out totalPages).MapTo<TDTO>();
            });

            pageCount = totalPages;

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

        #region GetDataTable

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
        
        #endregion

        #region GetDataSet

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
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