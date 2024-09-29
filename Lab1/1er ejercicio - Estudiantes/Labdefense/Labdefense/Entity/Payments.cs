using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Entity
{
    public class Payments
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Carnet { get; set; }
        public string? Identification { get; set; }
        public string? Motive { get; set; }
        public float Cordobas { get; set; }
        public DateTime DatePay { get; set; }
        public int CantPayments { get; set; }

    }
}
