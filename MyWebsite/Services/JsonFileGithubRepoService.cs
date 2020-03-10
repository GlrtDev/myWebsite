using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MyWebsite.Models;
using Microsoft.AspNetCore.Hosting;


namespace MyWebsite.Services
{
    public class JsonFileGithubRepoService
    {
        public JsonFileGithubRepoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "GithubRepos.json"); }
        }

        public IEnumerable<GithubRepo> GetGithubRepos()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<GithubRepo[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
