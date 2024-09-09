using Microsoft.AspNetCore.Mvc;
using System.Diagnostics; 
using WebApplication3.Models; 

namespace WebApplication3.Controllers 
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger; 

        // Constructor to initialize the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Assigning the logger instance to the private field
        }

        // Action method for the Index view
        public IActionResult Index()
        {
            return View(); // Returns the default view for the Index action
        }

        // Action method for the Privacy view
        public IActionResult Privacy()
        {
            return View(); // Returns the Privacy view
        }

        // Action method for submitting a claim
        public IActionResult SubmitClaim()
        {
            return View(); // Returns the view for submitting a claim
        }

        // Action method for creating a claim
        public IActionResult CreateClaim()
        {
            return View(); // Returns the view for creating a claim
        }

        // Action method indicating that a claim has been submitted
        public IActionResult ClaimSubmitted()
        {
            return View(); // Returns the view that confirms claim submission
        }

        // Action method for handling errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Prevents caching of error responses
        public IActionResult Error()
        {
            // Creates an ErrorViewModel with the current request ID for error handling
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}