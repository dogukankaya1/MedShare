using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class MedicineReceiver
    {
        public int Id { get; set; }

        public int ReceiverId { get; set; }

        public int MedicineId { get; set; }

        public Receiver Receiver { get; set; }
        public Medicine Medicine { get; set; }
    }
}
