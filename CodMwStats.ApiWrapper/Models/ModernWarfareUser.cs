using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class ModernWarfareUser
    {
        [JsonProperty("platformInfo")]
        public PlatformInfo PlatformInfo { get; set; }

        [JsonProperty("segments")]
        public Segment[] Segment { get; set; }
    }
}
