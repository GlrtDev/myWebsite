using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MyWebsite.Models
{
    public class GithubProfile
    {
        string login { get; set; }
        string avatar_url { get; set; }
        string html_url {get; set;}
        [JsonPropertyName("public_repos")]
        int repos_number { get; set; }
    }
}
