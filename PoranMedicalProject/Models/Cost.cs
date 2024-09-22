namespace PoranMedicalProject.Models
{
    public class Cost
    {
        public int CostID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public string ServiceType { get; set; }
        public decimal Amount { get; set; }
    }
}
