using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TinyProject.Models
{
    class Player
    {
        [JsonProperty(PropertyName = "id")]
        public int PlayerId { get; set; }
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }
        [JsonProperty(PropertyName = "team")]
        public Teams Team { get; set; }
    }
}
