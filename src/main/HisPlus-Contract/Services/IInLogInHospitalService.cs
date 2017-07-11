using System.ServiceModel;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;

namespace HisPlus.Contract.Services
{
    [ServiceContract]
    public interface IInLogInHospitalService : IGenericService<InLogInHospitalDTO, int>
    {
    }
}
