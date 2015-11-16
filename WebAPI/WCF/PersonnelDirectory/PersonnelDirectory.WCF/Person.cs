using System.Runtime.Serialization;

namespace PersonnelDirectory.WCF
{
    [DataContract(Namespace = "")]
    public class Person
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Department { get; set; }
    }
}