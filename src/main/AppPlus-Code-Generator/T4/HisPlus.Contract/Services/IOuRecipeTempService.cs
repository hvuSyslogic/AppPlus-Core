using System.ServiceModel;
using AppPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;

namespace HisPlus.Contract.Services
{
    [ServiceContract]
    public interface IOuRecipeTempService : IGenericService<OuRecipeTempDTO, int>
    {
    }
}
