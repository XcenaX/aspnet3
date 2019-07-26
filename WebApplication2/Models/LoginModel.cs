using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}