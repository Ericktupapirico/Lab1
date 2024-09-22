using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDLaboratorio2.Entities.Church
{
    public class Parishioner
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PeriodStart { get; set; }
        public string? PeriodEnd { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
/*
 * Entidades en la cual estaremos trabajando durante el manejo del arreglo de objetos
 */

