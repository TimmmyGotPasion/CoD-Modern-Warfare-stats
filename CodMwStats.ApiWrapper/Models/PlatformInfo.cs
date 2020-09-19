using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class PlatformInfo
    {
        [JsonProperty("platformSlug")]
        public string PlatformSlug { get; set; }

        [JsonProperty("platformUserHandle")]
        public string PlatformUserHandle { get; set; }

        [JsonProperty("platformUserIdentifier")]
        public string PlatformUserIdentifier { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }
}
