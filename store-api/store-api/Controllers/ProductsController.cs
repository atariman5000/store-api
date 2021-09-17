using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Route("api/Product")]
    public class ProductsController : ControllerBase
    {
        private List<Product> _products;
        public ProductsController()
        {
            if(_products == null)
            {
                _products = new List<Product>() {
                    new Product() { Id = 1, Name = "Toy", Price = 12.5m },
                    new Product() { Id = 2, Name = "Food", Price = 37.65m },
                    new Product() { Id = 3, Name = "Thing", Price = 500m }
                };
            }
        }
        private IList<Product> Products {
            get {
                return _products;
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var p = Products.FirstOrDefault(w => w.Id == id);
            return Ok(p);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if(product.Id == null)
            {
                product.Id = Products.Count() + 1;
            }
            this._products.Add(product);
            return Ok(product);
        }
    }

    public class Product {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
