using OMInsurance.Services.Entities;
using OMInsurance.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
namespace OMInsurance.Services.DMZ.PolicyStatusService
{
    public class PolicyStatusService : IPolicyStatusService
    {
        public List<Region> GetRegions()
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetRegions();
            }
        }

        public PolicyInfo GetStatusByUnifiedPolicyNumber(int regionId, string unifiedPolicyNumber)
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByUnifiedPolicyNumber(regionId, unifiedPolicyNumber);
            }
        }

        public PolicyInfo GetStatusByNumber(int regionId, string series, string number)
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByNumber(regionId, series, number);
            }
        }

        public PolicyInfo GetStatusByTemporaryPolicyNumber(int regionId, string temporaryPolicyNumber)
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByTemporaryPolicyNumber(regionId, temporaryPolicyNumber);
            }
        }

        public Policy GetStatusByFIOBirthday(int regionId, string Lastname, string Firstname, string Secondname, DateTime? Birthday)
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetStatusByFIOBirthday(regionId, Lastname, Firstname, Secondname, Birthday);
            }
        }

        public Person GetFIOByPhone(int regionId, string Phone)
        {
            using (var client = new InternalPolicyStatusService.PolicyStatusServiceClient())
            {
                return client.GetFIOByPhone(regionId, Phone);
            }
        }
    }
}
