using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Dtos
{
    public class UserCreateDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
