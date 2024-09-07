using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdefense.Models
{
    public class ArrayLogicPayments
    {
        private static readonly ArrayLogicPayments logicPay = new();
        public static ArrayLogicPayments ArraylogPay { get { return logicPay; } }
        private Payments[] _payments;
        private int size = 0, quantity = 0;


        public ArrayLogicPayments()
        {
            _payments = new Payments[size];
        }

        public void AddStudent(Payments newPayment)
        {
            if (quantity >= size)
            {
                size = size == 0 ? 1 : size + 1;
                Array.Resize(ref _payments, size);
            }
            _payments[quantity] = newPayment;
            ++quantity;
        }

        public Payments[] GetStudents() => _payments;

        public bool RemoveStudent(string Carnet)
        {
            var index = Array.FindIndex(_payments, p => Carnet.Equals(p.Carnet));
            if (index < 0) return false;
            for (int i = index; i < quantity - 1; i++)
            {
                _payments[i] = _payments[i + 1];
            }
            _payments[quantity - 1] = null;
            --quantity;
            return true;
        }


        public bool UpdateStudent(Payments payments)
        {
            if (string.IsNullOrEmpty(payments.Carnet)) return false;
            var index = Array.FindIndex(_payments, p => payments.Carnet.Equals(p.Carnet));
            if (index < 0) return false;


            _payments[index] = payments;
            return true;
        }


        public Payments[] SearchStudent(string carnet)
        {

            var pay = Array.Find(_payments, p => carnet.Equals(p.Carnet));


            return pay != null ? new[] { pay } : Array.Empty<Payments>();
        }
    }
}
