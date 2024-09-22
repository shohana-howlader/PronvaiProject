namespace PoranMedicalProject.Models
{
    public class Visa
    {
        public int VisaID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public string VisaStatus { get; set; }
        public decimal ProcessingFee { get; set; }
    }
}
