using Microsoft.AspNetCore.Mvc; 

namespace WebApplication3.Controllers 
{
    public class ClaimController : Controller // ClaimController inherits from the base Controller class
    {
        // Action method to handle GET requests for submitting a claim
        [HttpGet]
        public IActionResult SubmitClaim()
        {
            // Return the view associated with the claim submission form
            return View(); // This will render the SubmitClaim view
        }
    }
}