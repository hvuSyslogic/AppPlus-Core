using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialize.Linq.Nodes;
using System.ServiceModel;
using AppPlus.Infrastructure.Contracts.Messages;

namespace AppPlus.Infrastructure.Contracts.Services
{
    [ServiceContract]
    public interface IGenericService<TDTO, TKey> : IServiceRoot
        where TDTO : DtoBase<TKey>, new()
    {
        #region Create
        [OperationContract(Name = "Create")]
        TDTO Create(TDTO dto);

        [OperationContract(Name = "BatchCreate")]
        IEnumerable<TDTO> Create(IEnumerable<TDTO> dtos);
        #endregion

        #region Retrieve
        [OperationContract(Name = "RetrieveByKey")]
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
        [OperationContract(Name = "DeleteByKey")]
        void DeleteById(TKey id);

        [OperationContract(Name = "DeleteByEntity")]
        bool Delete(TDTO dto);        

        [OperationContract(Name = "BatchDelete")]
        int Delete(IEnumerable<TDTO> dtos);

        [OperationContract(Name = "DeleteByExpression")]
        int Delete(ExpressionNode predicateExpressionNode);

        [OperationContract(Name = "DeleteAll")]
        int DeleteAll();
        #endregion

        #region CreateOrUpdate
        [OperationContract(Name = "CreateOrUpdate")]
        Tuple<int, int> CreateOrUpdate(IEnumerable<TDTO> dtos);
        #endregion

        #region Count
        [OperationContract(Name = "Count")]
        int Count();

        [OperationContract(Name = "CountByExpression")]
        int Count(ExpressionNode predicateExpressionNode);
        #endregion

        #region Contains
        [OperationContract(Name = "Contains")]
        bool Contains(TDTO dto);

        [OperationContract(Name = "ContainsBy")]
        bool Contains(ExpressionNode predicateExpressionNode);
        #endregion

        #region Filter
        [OperationContract(Name = "Filter")]
        IEnumerable<TDTO> Filter(ExpressionNode predicateExpressionNode, int index = 0, int size = 50);
        #endregion
    }
}
