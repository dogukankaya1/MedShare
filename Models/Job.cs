using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class Job 
    {
        public int Id { get; set; }
        public string JobName { get; set; } //student, housewife, none etc. included
        public bool IsMd { get; set; } //medical degree 
        //did you work as medical employee or do you have medical degree

    }
}
