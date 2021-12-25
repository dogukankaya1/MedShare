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

       // public int JobId { get; set; } //fk
       // [ForeignKey("JobId")]// fk FarkliIsimId olsun isteseydik bu iki satır
       //eklenmek zorundaydı ama şimdi otomatik JobId diye yapıyor zaten
        public Job Job { get; set; } //foreign key
        public Education Education { get; set; } //fk
        public string Name { get; set; } 
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; } //=2020; //dersem default 2020 atar 
        //doğum tarihine.
        public Gender Gender { get; set; }
        public Country Country { get; set; } //fk
        public string Address { get; set; }
       // public int PhoneNumber { get; set; } 
        
    }
    public enum Gender
    {
        Female=1,
        Male=2,
        Other=3
    }
}
