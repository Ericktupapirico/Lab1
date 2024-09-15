namespace AEDLaboratorio2.Entities.DentalClinic
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public string? PatientSurname { get; set; }
        public string? Service { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}