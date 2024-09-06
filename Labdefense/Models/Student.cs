using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class Student
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? carnet { get; set; }
        public DateTime? dateRegister { get; set; }
        public string? Number { get; set; }
        public string? identifiaction { get; set; }
        public float IPar { get; set; }
        public float IIPar { get; set; }
        public float project { get; set; }
    }
}
