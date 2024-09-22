namespace PoranMedicalProject.Models
{
    public class TreatmentPlan
    {
        public int TreatmentPlanID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Many TreatmentPlans can include many Hospitals (many-to-many)
        public ICollection<TreatmentPlanHospital> TreatmentPlanHospitals { get; set; }
    }
}
