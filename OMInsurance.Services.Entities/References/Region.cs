using System.Runtime.Serialization;

namespace OMInsurance.Services.Entities
{
    [DataContract(Name = "Region")]
    public class Region
    {
        [DataMember(Name = "Id")]
        public long Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}
