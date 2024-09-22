namespace PoranMedicalProject.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public decimal TicketPrice { get; set; }

        // Tickets can be assigned to a patient
        public ICollection<Patient> Patients { get; set; }
    }
}
