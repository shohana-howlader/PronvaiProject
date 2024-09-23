namespace PoranMedicalProject.Models
{
    public class CommissionAgent
    {
        public int AgentID { get; set; }
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal TotalCommissionEarned { get; set; }

        // One agent can have many commissions
        public ICollection<Commission> Commissions { get; set; }
    }
}
