using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Dtos
{
    public class UserLoginDto
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}