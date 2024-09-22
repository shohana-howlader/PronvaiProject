namespace PoranMedicalProject.Models
{
    public class CustomerRequest
    {
        public int CustomerRequestID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Status { get; set; }

        // Each request may belong to one patient
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
