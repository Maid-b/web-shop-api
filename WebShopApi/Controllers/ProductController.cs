using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // GET: api/product
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new List<string>
            {
                "Laptop",
                "Phone",
                "Keyboard"
            };

            return Ok(products);
        }
    }
}