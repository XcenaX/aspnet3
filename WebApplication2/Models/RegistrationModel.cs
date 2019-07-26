using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}