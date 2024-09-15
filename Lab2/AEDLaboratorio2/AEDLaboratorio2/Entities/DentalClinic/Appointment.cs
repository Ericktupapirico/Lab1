namespace AEDLaboratorio2.Entities.DentalClinic
{
    public class Appointment
    {
        public int Id { get; set; }
        public Patient? Patient { get; set; }
        public string? Service { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}