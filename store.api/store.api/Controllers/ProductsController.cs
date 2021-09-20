﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            this._context.Products.Add(product);
            this._context.SaveChanges();
            return Ok(product);
        }
    }
}
