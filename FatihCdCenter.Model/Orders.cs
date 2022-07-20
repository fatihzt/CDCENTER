using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Model
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public string PaymentType { get; set; }
        
    }
}
