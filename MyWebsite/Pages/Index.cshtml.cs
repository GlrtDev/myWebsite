using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWebsite.Services;
using MyWebsite.Models;

namespace MyWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileGithubProfileService GithubProfileService;
        public IEnumerable<GithubProfile> GithubProfiles { get; private set; }
        
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileGithubProfileService profileService)
        {
            _logger = logger;
            GithubProfileService = profileService;
        }

        public void OnGet()
        {
            GithubProfiles = GithubProfileService.GetGithubProfiles();
        }
    }
}
