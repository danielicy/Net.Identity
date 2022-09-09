using System.ComponentModel.DataAnnotations;

namespace Cookie.Authentication.Models
{
    public class User
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
