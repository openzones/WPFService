using System.Runtime.Serialization;

namespace OMInsurance.Services.Entities
{
    [DataContract(Name = "DeliveryPoint")]
    public class DeliveryPoint
    {
        [DataMember(Name = "Id")]
        public long Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
