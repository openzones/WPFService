using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Core.Faults;
using System.ServiceModel;

namespace OMInsurance.Services.Interfaces
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        bool CheckPassword(string user, string password);
    }
}
