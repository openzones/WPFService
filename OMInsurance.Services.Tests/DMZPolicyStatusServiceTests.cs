using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using OMInsurance.Services.Tests.DMZPolicyStatusService;

namespace OMInsurance.Services.Tests
{
    [TestClass]
    public class DMZPolicyStatusServiceTests
    {
        [TestMethod]
        public void GetByNumber_Test()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                PolicyInfo status = client.GetStatusByNumber(1, "770000", "3026270680");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByNumber_Negative_Test()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                var status = client.GetStatusByNumber(1, "770100", "123321321");
            }
        }

        [TestMethod]
        public void GetByTemporaryPolicyNumber_Test()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                var status = client.GetStatusByTemporaryPolicyNumber(3, "151564119");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByTemporaryPolicyNumber_NegativeTest()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                var status = client.GetStatusByTemporaryPolicyNumber(1, "00000000");
            }
        }

        [TestMethod]
        public void GetByUnifiedPolicyNumber_Test()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                var status = client.GetStatusByUnifiedPolicyNumber(1, "5056730870001512");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByUnifiedPolicyNumber_NegativeTest()
        {
            using (var client = new DMZPolicyStatusService.PolicyStatusServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "OMS_Site";
                client.ClientCredentials.UserName.Password = "EFBpjyVA";
                var status = client.GetStatusByUnifiedPolicyNumber(3, "0247100882000749");
            }
        }
    }
}
