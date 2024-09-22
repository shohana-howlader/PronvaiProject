namespace PoranMedicalProject.Models
{
    public class FollowUp
    {
        public int FollowUpID { get; set; }
        public int PatientID { get; set; }
        public DateTime FollowUpDate { get; set; }
        public string Notes { get; set; }
        public Patient Patient { get; set; }
    }
}
