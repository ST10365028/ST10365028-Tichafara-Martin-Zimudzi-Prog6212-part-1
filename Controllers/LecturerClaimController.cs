using Microsoft.AspNetCore.Mvc; 
using WebApplication3.Models; 

namespace WebApplication3.Controllers // Defining the namespace for the LecturerClaimController
{
    public class LecturerClaimController : Controller // LecturerClaimController inherits from the base Controller class
    {
        // Action method to display the view for creating a new claim
        public IActionResult CreateClaim()
        {
            // Create a new instance of LecturerClaimModel and pass it to the view
            return View(new LecturerClaimModel());
        }

        // Action method to handle the submission of a claim
        [HttpPost]
        public IActionResult SubmitClaim(LecturerClaimModel model)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // If the model is valid, you would typically save the claim to a database here
                // For demonstration purposes, we'll simply display the submitted claim
                return View("ClaimSubmitted", model);
            }

            // If the model is invalid, return the CreateClaim view with the model
            return View("CreateClaim", model);
        }

        // Action method to handle adding a new module to the claim
        [HttpPost]
        public IActionResult AddModule(LecturerClaimModel model)
        {
            // Add a new instance of ModuleClaimModel to the ModuleClaims collection
            model.ModuleClaims.Add(new ModuleClaimModel());

            // Return the CreateClaim view with the updated model
            return View("CreateClaim", model);
        }
    }
}