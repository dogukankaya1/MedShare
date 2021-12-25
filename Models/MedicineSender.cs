using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class MedicineSender
    {
        public int Id { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }

        public int SenderId { get; set; }
        public Sender Sender { get; set; }


    }
}
