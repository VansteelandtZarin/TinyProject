﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TinyProject.Models
{
    class Teams
    {
        [JsonProperty(PropertyName = "id")]
        public int TeamId { get; set; }

        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "conference")]
        public string Conference { get; set; }

        [JsonProperty(PropertyName = "division")]
        public string Division { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
