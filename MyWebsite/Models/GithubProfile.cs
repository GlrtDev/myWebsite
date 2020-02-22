using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyWebsite.Models
{
    public class GithubProfile
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("avatar_url")]
        public string Avatar_url { get; set; }
        [JsonPropertyName("html_url")]
        public string Html_url { get; set; }
        [JsonPropertyName("Public_repos")]
        public int Repos_number { get; set; }

        public override string ToString() => JsonSerializer.Serialize<GithubProfile>(this);
    }
}
