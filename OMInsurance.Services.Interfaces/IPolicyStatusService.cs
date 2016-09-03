using OMInsurance.Services.Entities;
using OMInsurance.Services.Entities.Core;
using OMInsurance.Services.Entities.Core.Faults;
using System.ServiceModel;
using System;
using System.Collections.Generic;

namespace OMInsurance.Services.Interfaces
{
    [ServiceContract]
    public interface IPolicyStatusService
    {
        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        PolicyInfo GetStatusByUnifiedPolicyNumber (int regionId, string unifiedPolicyNumber);

        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        PolicyInfo GetStatusByNumber(int regionId, string series, string number);

        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        PolicyInfo GetStatusByTemporaryPolicyNumber(int regionId, string temporaryPolicyNumber);

        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        Policy GetStatusByFIOBirthday(int regionId, string lastname, string firstname, string secondname, DateTime? birthday);

        [OperationContract]
        [FaultContract(typeof(DataObjectNotFoundFault))]
        Person GetFIOByPhone(int regionId, string Phone);

        [OperationContract]
        List<Region> GetRegions();
    }
}
