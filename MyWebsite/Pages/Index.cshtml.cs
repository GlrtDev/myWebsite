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
        public JsonFileGithubProfileService GithubProfileService { get; }
        public IEnumerable<GithubProfile> GithubProfiles { get; private set; }

        public JsonFileGithubRepoService GithubRepoService { get; }
        public IEnumerable<GithubRepo> GithubRepos { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileGithubProfileService githubProfileService,
            JsonFileGithubRepoService githubRepoService)
        {
            _logger = logger;
            GithubProfileService = githubProfileService;
            GithubRepoService = githubRepoService;
        }

        public void OnGet()
        {
            GithubProfiles = GithubProfileService.GetGithubProfiles();
            GithubRepos = GithubRepoService.GetGithubRepos();
        }
    }
}
