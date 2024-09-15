using AEDEmpleados.Entities;

namespace AEDEmpleados.Models
{
    public class EmployeeModel
    {
        private static readonly EmployeeModel _instance = new();
        public static EmployeeModel Instance { get => _instance; }

        private EmployeeModel()
        { }

        private Employee[] _employees = [];
        private int _size = 0, _quantity = 0;

        public void Add(Employee employee)
        {
            if (_quantity >= _size)
            {
                Array.Resize(ref _employees, ++_size);
                _employees[_size - 1] = employee;
            }
            else
                _employees[_quantity] = employee;

            ++_quantity;
        }

        public bool Update(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.NationalID)) return false;

            var index = Array.FindIndex(_employees, e => employee.NationalID.Equals(e.NationalID));
            if (index < 0) return false;

            _employees[index] = employee;

            return true;
        }

        public bool Delete(string nationalID)
        {
            var index = Array.FindIndex(_employees, e => nationalID.Equals(e.NationalID));
            if (index < 0) return false;

            for (int i = index; i < _employees.Length - 1; i++)
                _employees[i] = _employees[i + 1];

            --_quantity;

            return true;
        }

        public Employee[] GetAll() => _employees.Take(_quantity).ToArray();

        public Employee? Find(string nationalID) => 
            _employees.Take(_quantity).FirstOrDefault(e => nationalID.Equals(e.NationalID));

        public decimal AverageSalary() => _employees.Average(e => e.Salary);

        public int SalaryIncrease(decimal percentage, Predicate<Employee> condition)
        {
            int count = 0;
            foreach (var emp in _employees)
            {
                if (condition(emp))
                {
                    emp.Salary += emp.Salary * percentage;
                    ++count;
                }
            }

            return count;
        }
    }
}