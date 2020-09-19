using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class Overview
    {
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}
