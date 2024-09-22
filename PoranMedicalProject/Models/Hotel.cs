namespace PoranMedicalProject.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public decimal Rate { get; set; }

        // One Hotel can be associated with many Patient bookings (can be implemented if needed)
        public ICollection<Patient> Patients { get; set; }
    }
}
