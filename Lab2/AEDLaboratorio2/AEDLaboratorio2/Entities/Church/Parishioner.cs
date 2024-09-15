namespace AEDLaboratorio2.Entities.Church
{
    public class Parishioner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public Tithe[] Tithes { get; set; } = new Tithe[12];
    }
}