using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum PhoneType
    {
        Home,Work,Cell
    }
    public class Phone
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }

        public ICollection<PersonPhone> PersonPhones { get; set; }
    }
}