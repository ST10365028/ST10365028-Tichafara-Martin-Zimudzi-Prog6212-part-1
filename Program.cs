
var builder = WebApplication.CreateBuilder(args);

// Register services for the application, enabling MVC with controllers and views
builder.Services.AddControllersWithViews();

// Build the application pipeline
var app = builder.Build();

// Configure the HTTP request pipeline based on the environment
if (!app.Environment.IsDevelopment())
{
    // Use a custom error handler in non-development environments
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // Enforce HTTP Strict Transport Security
}

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();
// Serve static files from wwwroot
app.UseStaticFiles();

// Enable routing capabilities
app.UseRouting();

// Enable authorization middleware
app.UseAuthorization();

// Define the default route mapping for the application
app.MapControllerRoute(
    name: "default", // Name of the route
    pattern: "{controller=Claim}/{action=SubmitClaim}/{id?}"); // Default controller and action

// Start the application and listen for incoming requests
app.Run();