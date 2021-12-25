using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class Medicine
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)] //defaultu identity. 1 1 artırıyor
        //none olunca otomatik vermiyor biz gireceğiz
        public int Id { get; set; } //Foreign Key, adds up by 1
        public string Name { get; set; }
        // public int Quantity { get; set; } //Q and Mass Q should be included in subclass
        public int BarcodeNo { get; set; }
        public int? Price { get; set; } //? for null data/can be left empty
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        //public int? AmountSent { get; set; } = 0;
        //public int? AmountReceived { get; set; } = 0;
        //public int? AmountLeft { get { return AmountLeft; } set { AmountLeft = AmountSent - AmountReceived; } } 
        public int? AmountSent { get; set; } 
        //public int? AmountReceived { get; set; }
        //public int? AmountLeft { get; set; } 

        public string SenderMessage { get; set; }
        public string ReceiverMessage { get; set; }

        public Sender Sender { get; set; } //fk
        public Receiver Receiver { get; set; }

    }
}
