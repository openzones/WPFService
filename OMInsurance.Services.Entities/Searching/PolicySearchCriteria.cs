using OMInsurance.Services.Entities.Core;
using System;
namespace OMInsurance.Services.Entities.Searching
{
    public class PolicySearchCriteria
    {
        #region Properties
        public long? RegionId { get; set; }
        public DateTime? ClientVisitDate { get; set; }
        public string PolicySeries { get; set; }
        public string PolicyNumber { get; set; }
        public string TemporaryPolicyNumber { get; set; }
        public string UnifiedPolicyNumber { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public char? Sex { get; set; }
        public string Phone { get; set; }
        #endregion
    }
}
