using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; } 
        public int Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephonNumber { get; set; }
        
        //public virtual LibraryCard LibraryCard { get; set; }
    }
}