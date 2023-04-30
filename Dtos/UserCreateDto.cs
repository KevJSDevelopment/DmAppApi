using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using DMApp.Models;

namespace DmAppAPI.Dtos
{
    public class UserCreateDto
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string Password { get; set; }
        public byte[] ImageFiles { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
