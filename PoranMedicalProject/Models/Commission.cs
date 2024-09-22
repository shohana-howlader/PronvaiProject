namespace PoranMedicalProject.Models
{
    public class Commission
    {
        public int CommissionID { get; set; }
        public int AgentID { get; set; }
        public CommissionAgent CommissionAgent { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public decimal CommissionAmount { get; set; }
        public DateTime DateEarned { get; set; }
    }
}
