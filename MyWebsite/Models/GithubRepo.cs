using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyWebsite.Models
{
    public class GithubRepo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdateDate { get; set; }
        [JsonPropertyName("html_url")]
        public string Html_url { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("language")]
        public string Language { get; set; }

        public override string ToString() => JsonSerializer.Serialize<GithubRepo>(this);
    }
}
