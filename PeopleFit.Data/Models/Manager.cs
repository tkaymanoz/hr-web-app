using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleFit.Data.Models
{
    public class Manager
    {
        public int ID { get; set; }
        [ForeignKey("Subordinate")]
        public int SubordinateID { get; set; }
        [ForeignKey("Leader")]
        public int LeaderID { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
        
        public Employee Subordinate { get; set; }
        
        public Employee Leader { get; set; }        
    }
}