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
        #region Add

        [OperationContract]
        TDTO Add(TDTO dto);

        [OperationContract]
        IEnumerable<TDTO> AddBatch(IEnumerable<TDTO> addValueFactory);
        
        #endregion        

        #region Get

        [OperationContract]
        TDTO GetById(TKey id);

        [OperationContract]
        IEnumerable<TDTO> GetBy(ExpressionNode predicateExpressionNode);

        [OperationContract]
        IEnumerable<TDTO> GetAll();

        #endregion

        #region Update

        [OperationContract]
        void Update(TDTO dto);

        [OperationContract]
        void UpdateBatch(IEnumerable<TDTO> updateValueFactory);
        
        #endregion

        #region Delete

        [OperationContract]
        void DeleteById(TKey id);

        [OperationContract]
        void DeleteByObject(TDTO obj);

        [OperationContract]
        void DeleteBatch(IEnumerable<TDTO> dtos);

        [OperationContract]
        int DeleteBy(ExpressionNode predicateExpressionNode);

        [OperationContract]
        int DeleteAll();
        
        #endregion

        #region AddOrUpdate
        [OperationContract]
        Tuple<int, int> AddOrUpdate(IEnumerable<TDTO> valueFactory);
        #endregion

        #region Count

        [OperationContract]
        long Count();

        [OperationContract]
        long CountBy(ExpressionNode predicateExpressionNode);
       
        #endregion

        #region Contains

        [OperationContract]
        bool Contains(TKey id);

        [OperationContract]
        bool ContainsBy(ExpressionNode predicateExpressionNode);
        
        #endregion

        #region GetByPage
        [OperationContract(Name="GetByPageBy")]
        IEnumerable<TDTO> GetByPage(ExpressionNode predicateExpressionNode, int pageNumber, int pageSize, out int pageCount);

        [OperationContract]
        IEnumerable<TDTO> GetByPage(int pageNumber, int pageSize, out int pageCount);        
        #endregion
    }
}
