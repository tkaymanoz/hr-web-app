namespace PeopleFit.Data.Models
{
    public class PersonPhone
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int PhoneID { get; set; }
        public Person Person { get; set; }
        public Phone Phone { get; set; }
    }
}