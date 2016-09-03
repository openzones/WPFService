using OMInsurance.Entities;
using OMInsurance.Services.Interface;
namespace OMInsurance.Services.DMZ.PolicyStatusService
{
    public class PolicyStatusService : IPolicyStatusService
    {
        public PolicyStatus GetStatusByUnifiedPolicyNumber(string unifiedPolicyNumber)
        {
            using (var client = new OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByUnifiedPolicyNumber(unifiedPolicyNumber);
            }
        }

        public PolicyStatus GetStatusByNumber(string series, string number)
        {
            using (var client = new OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByNumber(series, number);
            }
        }

        public PolicyStatus GetStatusByTemporaryPolicyNumber(string temporaryPolicyNumber)
        {
            using (var client = new OMInsurance.Services.DMZ.PolicyStatusService.Host.InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByTemporaryPolicyNumber(temporaryPolicyNumber);
            }
        }
    }
}
