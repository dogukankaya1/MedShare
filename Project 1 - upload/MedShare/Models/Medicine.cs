using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class Medicine
    {
        public int Id { get; set; } //Foreign Key, adds up by 1
        public string Name { get; set; }
        // public int Quantity { get; set; } //Q and Mass Q should be included in subclass
        public int BarcodeNo { get; set; }
        public int? Price { get; set; } //? for null data/can be left empty
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Sender Sender { get; set; } //fk
        public Receiver Receiver { get; set; }

    }
}
