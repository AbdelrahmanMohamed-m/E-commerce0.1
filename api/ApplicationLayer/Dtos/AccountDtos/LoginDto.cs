using System.ComponentModel.DataAnnotations;

namespace api.ApplicationLayer.Dtos.LoginDto
{
    public class LoginDto
    {

        [Required]
        public string username { get; set; } = "";
        [Required]
        public string password { get; set; } = "";

    }
}