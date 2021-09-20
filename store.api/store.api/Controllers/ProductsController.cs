using Microsoft.AspNetCore.Mvc;
using Store.DAL.Data;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Route("api/Product")]
    public class ProductsController : ControllerBase
    {
        private StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var results = _context.Products.ToList();
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var p = _context.Products.FirstOrDefault(w => w.Id == id);
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var p = this._context.Products.FirstOrDefault(w => w.Id == id);
            this._context.Products.Remove(p);
            this._context.SaveChanges();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if(product.Id > 0)
            {
                this._context.Products.Update(product);
            } else
            {
                this._context.Products.Add(product);
            }
            this._context.SaveChanges();
            return Ok(product);
        }
    }
}
