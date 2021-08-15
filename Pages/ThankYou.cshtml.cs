using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace JohnnyGuru.Pages
{
    public class ThankYouModel : PageModel
    {
        private readonly ILogger<ThankYouModel> _logger;

        public ThankYouModel(ILogger<ThankYouModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
