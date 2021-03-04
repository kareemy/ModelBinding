using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;        // Required using directives for Data Validation
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapDemo.Pages
{
    public class BootstrapModel : PageModel
    {
        // Model Binding Step 1: Create Property FirstName
        // Step 2: Add [BindProperty] Decorator
        [BindProperty]
        // Add Data Validation Rules
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        public string LastName {get; set;}
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
            _logger.LogWarning($"On Post {FirstName} {LastName}");
        }
    }
}