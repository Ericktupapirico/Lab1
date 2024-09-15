namespace AEDEmpleados.Entities
{
    public class Employee
    {
        public string? NationalID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public decimal Salary { get; set; }
        public int Childrens { get; set; }
        public Sex Sex { get; set; }
        public byte[]? Photo { get; set; }
    }
}
