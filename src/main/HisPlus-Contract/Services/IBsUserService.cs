using System.ServiceModel;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;

namespace HisPlus.Contract.Services
{
    [ServiceContract]
    public interface IBsUserService : IGenericService<BsUserDTO, int>
    {
        [OperationContract]
        BsUserDTO ValidateUser(string userId, string password);
    }
}
