using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialize.Linq.Nodes;
using System.ServiceModel;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Infrastructure.Contract.Services
{
    [ServiceContract]
    public interface IGenericService<TDTO, TKey> : IServiceRoot
        where TDTO : DtoBase<TKey>, new()
        where TKey : struct
    {
        #region Create

        [OperationContract(Name = "Create")]
        TDTO Create(TDTO dto);

        [OperationContract(Name = "BatchCreate")]
        IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos);
        
        #endregion

        #region Retrieve

        [OperationContract(Name = "RetrieveById")]
        TDTO RetrieveById(TKey id);

        [OperationContract(Name = "RetrieveByExpression")]
        IEnumerable<TDTO> Retrieve(ExpressionNode predicateExpressionNode);

        [OperationContract(Name = "RetrieveAll")]
        IEnumerable<TDTO> RetrieveAll();

        #endregion

        #region Update

        [OperationContract(Name = "Update")]
        void Update(TDTO dto);

        [OperationContract(Name = "BatchUpdate")]
        void Update(IEnumerable<TDTO> dtos);

        //[OperationContract(Name = "UpdateByExpression")]
        //[FaultContract(typeof(ServiceFault))]
        //int Update(TDTO dto, ExpressionNode predicateExpressionNode = null);

        // int Update<TEntity>(Expression<Func<TEntity, TEntity>> updateExpression,
        //Expression<Func<TEntity, bool>> predicate = null)
        //where TEntity : EntityBase, new();
        
        #endregion

        #region Delete

        [OperationContract(Name = "DeleteById")]
        void DeleteById(TKey id);

        [OperationContract(Name = "DeleteByEntity")]
        void Delete(TDTO dto);

        [OperationContract(Name = "BatchDelete")]
        void Delete(IEnumerable<TDTO> dtos);

        [OperationContract(Name = "DeleteByExpression")]
        int Delete(ExpressionNode predicateExpressionNode);

        [OperationContract(Name = "DeleteAll")]
        int DeleteAll();
        
        #endregion

        //#region CreateOrUpdate
        //[OperationContract(Name = "CreateOrUpdate")]
        //Tuple<int, int> CreateOrUpdate(IEnumerable<TDTO> dtos);
        //#endregion

        #region Count

        [OperationContract(Name = "Count")]
        long Count();

        [OperationContract(Name = "CountByExpression")]
        long Count(ExpressionNode predicateExpressionNode);
       
        #endregion

        #region Contains

        [OperationContract(Name = "ContainsById")]
        bool Contains(TKey id);

        [OperationContract(Name = "Contains")]
        bool Contains(TDTO dto);

        [OperationContract(Name = "ContainsByExpression")]
        bool Contains(ExpressionNode predicateExpressionNode);
        
        #endregion

        #region RetrievePagedData

        [OperationContract(Name = "RetrievePagedDataByExpression")]
        IEnumerable<TDTO> RetrievePagedData(ExpressionNode predicateExpressionNode, int pageNumber, int pageSize, out int pageCount);

        [OperationContract(Name = "RetrievePagedData")]
        IEnumerable<TDTO> RetrievePagedData(int pageNumber, int pageSize, out int pageCount);
        
        #endregion
    }
}
