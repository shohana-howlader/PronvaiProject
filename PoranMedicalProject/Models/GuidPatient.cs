namespace PoranMedicalProject.Models
{
    public class GuidPatient
    {
        public int GuidPatientID { get; set; }

        public int GuidID { get; set; }
        public Guid Guid { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}