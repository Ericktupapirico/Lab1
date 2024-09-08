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

        public void AddPayment(Payments newPayment)
        {
            if (!CanPayment(newPayment.Carnet))
            {
                MessageBox.Show("No Puede pagar sin haber registrado un estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AutoFIllCamp(newPayment);
            
            if (quantity >= size)
            {
                size = size == 0 ? 1 : size + 1;
                Array.Resize(ref _payments, size);
            }
            _payments[quantity] = newPayment;
            ++quantity;
        }

        public Payments[] GetPayments() => _payments;

        public bool RemovePayment(string carnet)
        {
            var index = Array.FindIndex(_payments, p => carnet.Equals(p.Carnet));
            if (index < 0) return false;
            for (int i = index; i < quantity - 1; i++)
            {
                _payments[i] = _payments[i + 1];
            }
            _payments[quantity - 1] = null;
            --quantity;
            return true;
        }

        public bool UpdatePayment(Payments payment)
        {
            if (string.IsNullOrEmpty(payment.Carnet)) return false;
            var index = Array.FindIndex(_payments, p => payment.Carnet.Equals(p.Carnet));
            if (index < 0) return false;

            _payments[index] = payment;
            return true;
        }

        public Payments[] SearchPayment(string carnet)
        {
            var pay = Array.Find(_payments, p => carnet.Equals(p.Carnet));
            return pay != null ? new[] { pay } : Array.Empty<Payments>();
        }

         public bool CanPayment(string Carnet)
        {
            var StudentExist = ArrayLogic.Arraylog.SearchStudent(Carnet).Any();
            return StudentExist;
        }
        public void AutoFIllCamp(Payments payments)
        {
            var StudentFills = ArrayLogic.Arraylog.SearchStudent(payments.Carnet).FirstOrDefault();
            if (payments != null)
            {
                payments.Name = StudentFills.Name;
                payments.Surname = StudentFills.Surname;
                payments.Identification = StudentFills.Identification;
            }
        }


    }
}
