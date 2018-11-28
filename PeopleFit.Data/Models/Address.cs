using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int City { get; set; }
        public string CountryID { get; set; }
        public Country Country{ get; set; }

        public ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}