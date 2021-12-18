using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class Person
    {
        public int Id { get; set; }

        public Job Job { get; set; } //foreign key
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Country Country { get; set; } //fk
        
    }
    public enum Gender
    {
        Female=1,
        Male=2,
        Other=3
    }
}
