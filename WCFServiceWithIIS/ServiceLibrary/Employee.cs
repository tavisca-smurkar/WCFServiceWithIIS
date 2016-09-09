using System;
using System.Runtime.Serialization;

namespace ServiceLibrary
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
