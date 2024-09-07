using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class Payments
    {
        public int Id;
        public string? Carnet { get; set; }
        public string? motive { get; set; }
        public float cordobas { get; set; }
        public DateTime date { get; set; }
        public int cantPayments { get; set; }
    }
}
