using System;
using OMInsurance.Services.Entities.Core;
using System.Runtime.Serialization;

namespace OMInsurance.Services.Entities
{
    [DataContract(Name = "Person")]
    public class Person
    {
        [DataMember(Name = "Lastname")]
        public string Lastname { get; set; }

        [DataMember(Name = "Firstname")]
        public string Firstname { get; set; }

        [DataMember(Name = "Secondname")]
        public string Secondname { get; set; }

        public Person(Policy policy)
        {
            this.Lastname = policy.Lastname;
            this.Firstname = policy.Firstname;
            this.Secondname = policy.Secondname;
        }
    }
}
