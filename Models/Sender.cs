using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedShare.Models
{
    public class Sender:Person
    {
        public string Message { get; set; } //Message sent by sender. Just a dummy for now.

    //bir ilacın birden fazla göndereni bir gönderenin birden fazla gönderdiği ilaç
    //olabilir. çoka çok ilişki. many to many yani. araya tablo geliyor.
    //ikisinin primary keylerinden olusan yeni bir primary key olusturucaz
    
    
    }
}
