namespace PeopleFit.Data.Models
{
    public class BusinessUnit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ManagingDirectorID { get; set; }
        public Employee ManagingDirector { get; set; }
    }
}