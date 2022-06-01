using System.Text.Json.Serialization;

namespace SistemaApp.Core.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<User> Users { get; set; }
    }
}