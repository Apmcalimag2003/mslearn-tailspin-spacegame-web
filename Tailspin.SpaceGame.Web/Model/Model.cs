using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.Web
{
    public class Model
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}