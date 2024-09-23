using Microsoft.AspNetCore.Identity;
using System;

namespace PoranMedicalProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public ICollection<Patient>  Patients { get; set; }

        // One-to-one or one-to-many relation with Employee (depending on your structure)
        public ICollection<Employee> Employees { get; set; }
        public ICollection<CommissionAgent> CommissionAgents { get; set; }
    }
}