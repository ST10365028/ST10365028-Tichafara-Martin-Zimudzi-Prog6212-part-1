using Microsoft.AspNetCore.Mvc; 

namespace WebApplication3.Models 
{
    // Model class for a module claim
    public class ModuleClaimModel
    {
        // Property for the module name
        public string Module { get; set; }

        // Property for the programme name
        public string Programme { get; set; }

        // Property for the number of hours worked
        public int HoursWorked { get; set; }

        // Property for the hourly rate
        public decimal HourlyRate { get; set; }

        // Property for calculating the total claim amount
        public decimal TotalClaim
        {
            get
            {
                // Calculating the total claim by multiplying hours worked and hourly rate
                return HoursWorked * HourlyRate;
            }
        }
    }
}