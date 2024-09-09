using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Models
{
    public class LecturerClaimModel
    {
        public string LecturerName { get; set; }
        public string LecturerSurname { get; set; }
        public string EmployeeNumber { get; set; }
        public string ContactDetails { get; set; }
        public List<ModuleClaimModel> ModuleClaims { get; set; } = new List<ModuleClaimModel>();
    }
}
