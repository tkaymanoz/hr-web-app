using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class Email
    {
        public int ID { get; set; }
        public int Address { get; set; }

        public ICollection<PersonEmail> PersonEmails { get; set; }
    }
}