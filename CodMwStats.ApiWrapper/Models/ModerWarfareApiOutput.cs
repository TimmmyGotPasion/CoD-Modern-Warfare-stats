using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class ModerWarfareApiOutput
    {
        [JsonProperty("data")]
        public ModernWarfareUser Data { get; set; }
    }
}
