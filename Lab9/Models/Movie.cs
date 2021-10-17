using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab9.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsTecsup { get; set; }
    }
}