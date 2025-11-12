using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TailSpin.SpaceGame.Web
{
    public class Profile : Model
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("achievements")]
        public List<string> Achievements { get; set; }
    }
}