namespace PoranMedicalProject.Models
{
    public class Guid
    {
        public int GuidID { get; set; }
        public string GuidName { get; set; }
        public string PhoneNo { get; set; }

        // One Guid can be assigned to many Patients
        public ICollection<GuidPatient> GuidPatients { get; set; }
    }
}
