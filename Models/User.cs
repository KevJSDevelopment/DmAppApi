using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class User
    {
        [Key] public int UserId { get; set; }
        [Required] public string? Username { get; set; }
        [Required] public string? Email { get; set; }
        [Required] public string? Password { get; set; }
        public ICollection<Character>? Characters { get; set; }
    }
}
