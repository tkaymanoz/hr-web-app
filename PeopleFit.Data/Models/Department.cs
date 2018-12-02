using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BusinessUnitID { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}