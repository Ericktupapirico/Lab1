using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class Student
    {

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Carnet { get; set; }
        public DateTime? DateRegister { get; set; }
        public string? Number { get; set; }
        public string? Identification { get; set; }
        public float IPar { get; set; }
        public float IIPar { get; set; }
        public float Project { get; set; }

        public float Test { get; set; }
        public float Finalgrades { get; set; }
        public float finalgrades()
        {

            if (IPar > 30)
            {
                MessageBox.Show("Nota: " + IPar + " Invalido");
                IPar = 0;
            }

            if (IIPar > 30)
            {
                MessageBox.Show("Nota: " + IIPar + " Invalido");
                IIPar = 0;
            }

            if (Project > 20)
            {
                MessageBox.Show("Nota: " + Project + " Invalido");
                Project = 0;
            }

            if (Test > 20)
            {
                MessageBox.Show("Nota: " + Test + " Invalido");
                Test = 0;
            }
            Finalgrades = IPar + IIPar + Project + Test;
            return Finalgrades;
        }
    }
}
