using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class Student
    {
  
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? carnet { get; set; }
        public DateTime? dateRegister { get; set; }
        public string? Number { get; set; }
        public string? identification { get; set; }
        public float IPar { get; set; }
        public float IIPar { get; set; }
        public float project { get; set; }
    
        public float test { get; set; }
        public float Finalgrades { get; set; }
        public float finalgrades()
        {  
            
             if(IPar > 30)
            {
                MessageBox.Show("Nota: " + project + " Invalido");
                    IPar = 0; 
            }

            if (IIPar > 30)
            {
                MessageBox.Show("Nota: " + IIPar + " Invalido");
                IIPar = 0;
            }

            if (project > 20)
            {
                MessageBox.Show("Nota: " + project + " Invalido");
                project = 0;
            }

            if (test > 20)
            {
                MessageBox.Show("Nota: " + test + " Invalido");
                test = 0;
            }
            Finalgrades = IPar + IIPar + project + test;
            return Finalgrades;
        }
    }
}
