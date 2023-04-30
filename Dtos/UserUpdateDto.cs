using System.ComponentModel.DataAnnotations;

namespace DMApp.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? DisplayName { get; set; }
        [Required]
        public string? Password { get; set; }
        public byte[]? ImageFiles { get; set; }
    }
}
