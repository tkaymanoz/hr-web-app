namespace PeopleFit.Data.Models
{
    public class PersonAddress
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int AddressID { get; set; }

        public Person Person { get; set; }
        public Address Address { get; set; }
    }
}