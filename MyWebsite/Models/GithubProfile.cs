using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MyWebsite.Models
{
    public class GithubProfile
    {
        public string Login { get; set; }
        public string Avatar_url { get; set; }
        public string Html_url { get; set; }
        [JsonPropertyName("public_repos")]
        public int Repos_number { get; set; }

        public override string ToString() => JsonSerializer.Serialize<GithubProfile>(this);
    }
}
