using System;
using Newtonsoft.Json;

namespace APITestsUsers.Models
{
    public class DoRegisterRequestModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
