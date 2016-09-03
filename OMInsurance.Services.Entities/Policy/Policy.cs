using System;
using OMInsurance.Services.Entities.Core;
using System.Runtime.Serialization;

namespace OMInsurance.Services.Entities
{
    [DataContract(Name = "Policy")]
    public class Policy
    {
        public Policy()
        {
            PolicyStatus = new PolicyStatus();
            DeliveryCenter = new DeliveryCenter();
            DeliveryPoint = new DeliveryPoint();
        }

        public long Id { get; set; }
        public long RegionId { get; set; }

        [DataMember(Name = "TemporaryPolicyNumber")]
        public string TemporaryPolicyNumber { get; set; }

        [DataMember(Name = "UnifiedPolicyNumber")]
        public string UnifiedPolicyNumber { get; set; }

        [DataMember(Name = "PolicySeries")]
        public string PolicySeries { get; set; }

        [DataMember(Name = "PolicyNumber")]
        public string PolicyNumber { get; set; }

        [DataMember(Name = "PolicyStatus")]
        public PolicyStatus PolicyStatus { get; set; }

        [DataMember(Name = "DeliveryCenter")]
        public DeliveryCenter DeliveryCenter { get; set; }

        [DataMember(Name = "DeliveryPoint")]
        public DeliveryPoint DeliveryPoint { get; set; }

        [DataMember(Name = "ClientVisitDate")]
        public DateTime? ClientVisitDate { get; set; }

        [DataMember(Name = "ApplicationMethod")]
        public string ApplicationMethod { get; set; }

        [DataMember(Name = "Lastname")]
        public string Lastname { get; set; }

        [DataMember(Name = "Firstname")]
        public string Firstname { get; set; }

        [DataMember(Name = "Secondname")]
        public string Secondname { get; set; }

        [DataMember(Name = "Sex")]
        public string Sex { get; set; }

        [DataMember(Name = "Phone")]
        public string Phone { get; set; }

        [DataMember(Name = "Birthday")]
        public DateTime? Birthday { get; set; }

        [DataMember(Name = "IssueDate")]
        public DateTime? IssueDate { get; set; }

        [DataMember(Name = "StatusDate")]
        public DateTime? StatusDate { get; set; }

        [DataMember(Name = "Category")]
        public string Category { get; set; }

        [DataMember(Name = "Citizenship")]
        public string Citizenship { get; set; }

        [DataMember(Name = "NomernikStatus")]
        public string NomernikStatus { get; set; }

        [DataMember(Name = "LPU")]
        public string LPU { get; set; }

        [DataMember(Name = "AttachmentDate")]
        public DateTime? AttachmentDate { get; set; }

        [DataMember(Name = "AttachmentMethod")]
        public string AttachmentMethod { get; set; }

        [DataMember(Name = "BlankNumber")]
        public string BlankNumber { get; set; }
        
        public DateTime? SaveDate { get; set; }

    }
}
