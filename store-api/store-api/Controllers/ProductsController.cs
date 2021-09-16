using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IList<Product> Products {
            get {
                var products = new List<Product>() {
                    new Product() { Id = 0, Name = "Toy", Price = 12.5m },
                    new Product() { Id = 1, Name = "Food", Price = 37.65m },
                    new Product() { Id = 2, Name = "Thing", Price = 500m }
                };
                
                return products;
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }
    }

    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
