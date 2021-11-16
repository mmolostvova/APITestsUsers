using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APITestsUsers.Models
{
    public class CreateUserRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tasks")]
        public int[] Tasks { get; set; }
    }
}
