using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя обязательное поле")]
        [MinLength(5, ErrorMessage = "Имя должно состоять минимум из 5 букв")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Price is Required")]
        public float? Price { get; set; }
    }
}