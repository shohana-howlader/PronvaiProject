namespace PoranMedicalProject.Models
{
    public class TreatmentPlanHospital
    {
        // Junction Table for many-to-many relation between TreatmentPlan and Hospital
        public int TreatmentPlanID { get; set; }
        public TreatmentPlan TreatmentPlan { get; set; }

        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
    }
}