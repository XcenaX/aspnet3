using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DataStorage
    {
        private static DataStorage instance;

        public List<Product> Products { get; set; } = new List<Product>();

        private DataStorage()
        {
            Products.Add(new Product { Id = 1, Name = "Молоко", Price = 350f });
            Products.Add(new Product { Id = 2, Name = "Хлеб", Price = 70f });
            Products.Add(new Product { Id = 1, Name = "Колбаса", Price = 1250f });
            Products.Add(new Product { Id = 1, Name = "Майонез", Price = 270f });
        }

        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataStorage();
                return instance;
            }
        }
    }
}