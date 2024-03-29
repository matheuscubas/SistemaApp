﻿using System.Text.Json.Serialization;

namespace SistemaApp.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        [JsonIgnore]
        public Role Role { get; set; }
    }
}