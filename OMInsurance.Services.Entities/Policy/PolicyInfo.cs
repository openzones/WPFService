using System;
using OMInsurance.Services.Entities.Core;
using System.Runtime.Serialization;

namespace OMInsurance.Services.Entities
{
    [DataContract(Name = "PolicyInfo")]
    public class PolicyInfo
    {
        public PolicyInfo()
        {
            this.Status = new PolicyStatus();
            this.DeliveryCenter = new DeliveryCenter();
            this.DeliveryPoint = new DeliveryPoint();
        }

        [DataMember(Name = "Status")]
        public PolicyStatus Status { get; set; }

        [DataMember(Name = "StatusDate")]
        public DateTime? StatusDate { get; set; }

        [DataMember(Name = "ClientVisitDate")]
        public DateTime? ClientVisitDate { get; set; }

        [DataMember(Name = "DeliveryCenter")]
        public DeliveryCenter DeliveryCenter { get; set; }

        [DataMember(Name = "DeliveryPoint")]
        public DeliveryPoint DeliveryPoint { get; set; }

        public PolicyInfo(Policy policy)
        {
            this.Status = new PolicyStatus();
            this.DeliveryCenter = new DeliveryCenter();
            this.DeliveryPoint = new DeliveryPoint();
            this.Status.Id = policy.PolicyStatus.Id;
            this.Status.Name = policy.PolicyStatus.Name;
            this.StatusDate = policy.StatusDate;
            this.ClientVisitDate = policy.ClientVisitDate;
            this.DeliveryCenter.Id = policy.DeliveryCenter.Id;
            this.DeliveryCenter.Name = policy.DeliveryCenter.Name;
            this.DeliveryCenter.Code = policy.DeliveryCenter.Code;
            this.DeliveryPoint.Id = policy.DeliveryPoint.Id;
            this.DeliveryPoint.Name = policy.DeliveryPoint.Name;
            this.DeliveryPoint.Code = policy.DeliveryPoint.Code;
        }
    }
}
