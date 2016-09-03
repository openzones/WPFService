using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using OMInsurance.Services.Tests.PolicyStatusService;

namespace OMInsurance.Services.Tests
{
    [TestClass]
    public class PolicyStatusServiceTests
    {
        [TestMethod]
        public void GetByNumber_Test_Moscow()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                PolicyInfo policyInfo = client.GetStatusByNumber(1, "770000", "8018570419");
            }
        }

        [TestMethod]
        public void GetByNumber_Test_Region()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByNumber(2, "123123", "1234567890");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByNumber_Negative_Test()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByNumber(1, "770100", "3029151170");
            }
        }

        [TestMethod]
        public void GetByTemporaryPolicyNumber_Test_Moscow()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByTemporaryPolicyNumber(1, "046865356");
            }
        }

        [TestMethod]
        public void GetByTemporaryPolicyNumber_Test_Region()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByTemporaryPolicyNumber(2, "123993429");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByTemporaryPolicyNumber_NegativeTest()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByTemporaryPolicyNumber(1, "00000000");
            }
        }

        [TestMethod]
        public void GetByUnifiedPolicyNumber_Test_Moscow()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByUnifiedPolicyNumber(1, "5090489783000735");
            }
        }

        [TestMethod]
        public void GetByUnifiedPolicyNumber_Test_Region()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByUnifiedPolicyNumber(2, "5090489783000735");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<DataObjectNotFoundFault>))]
        public void GetByUnifiedPolicyNumber_NegativeTest()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policyInfo = client.GetStatusByUnifiedPolicyNumber(1, "7748030884000500");
            }
        }

        [TestMethod]
        public void GetRegions()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var listRegions = client.GetRegions();
            }
        }

        [TestMethod]
        public void GetStatusByFIOBirthday_Moscow()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policy = client.GetStatusByFIOBirthday(1, "Иванов", "Иван", "Иванович", new DateTime(1966, 2, 17));
            }
        }

        [TestMethod]
        public void GetStatusByFIOBirthday_Region()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policy = client.GetStatusByFIOBirthday(2, "Иванов", "Иван", "Иванович", new DateTime(1966, 2, 17));
            }
        }

        [TestMethod]
        public void GetStatusByPhone_Moscow()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policy = client.GetFIOByPhone(1, "(954)223-11-23");
            }
        }

        [TestMethod]
        public void GetStatusByPhone_Region()
        {
            using (var client = new PolicyStatusService.PolicyStatusServiceClient())
            {
                var policy = client.GetFIOByPhone(2, "(954)223-11-23");
            }
        }
    }
}
