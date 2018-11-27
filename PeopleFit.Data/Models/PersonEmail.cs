namespace PeopleFit.Data.Models
{
    public class PersonEmail
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public int EmailID { get; set; }

        public Person Person { get; set; }
        public Email Email { get; set; }
    }
}