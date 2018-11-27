using System;
using System.Collections.Generic;

namespace PeopleFit.Data.Models
{
    public enum Sex
    {
        Male, Female, Unspecified
    }
    public class Person
    {
        public int ID { get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime DateOfBirth {get; set;}
        public Sex? Sex {get; set;}
        public string Nationality {get; set;}
        public string Identification {get; set;}

        public string FullName
        {
            get { return LastName+","+FirstName;}
        }
        
        public Employee Employee { get; set; }


        
    }
}