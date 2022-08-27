using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations; // Required using directives for Data Validation

namespace ModelBinding.Pages;

public class BootstrapModel : PageModel
{
    // Model Binding Step 1: Create Property FirstName
    // Step 2: Add [BindProperty] Decorator
    [BindProperty]
    // Add Data Validation Rules
    [Display(Name = "First Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string FirstName {get; set;} = string.Empty;

    [BindProperty]
    public string LastName {get; set;} = string.Empty;

    private readonly ILogger<BootstrapModel> _logger;

    public BootstrapModel(ILogger<BootstrapModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        // Print out FirstName and LastName just like any other property.
        _logger.LogWarning($"OnPost Called {FirstName} {LastName}");
    }
}