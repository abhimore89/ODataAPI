using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataAPI.Controllers
{
   // [Route("api/v1/[controller]/")]
    public class ProductsController : ODataController
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Bread",
                Category = "Food",
                Description = "Britannia Bread (450 gms)",
                Slug = "britannia-bread-450gms"

            },
            new Product()
            {
                Id = 2,
                Name = "Echo Dot",
                Category = "Electronics",
                Description = "Echo Dot 3rd Gen",
                Slug = "echo-dot-3rdgen"

            },
            new Product()
            {
                Id = 3,
                Name = "Echo",
                Category = "Electronics",
                Description = "Echo 4th Gen, 2020 release, Premium sound powered by Dolby and Alexa(white)",
                Slug = "echo-4thgen"

            }
        };
        // GET: api/values

        
        [HttpGet]
        [EnableQuery()]
        public IActionResult Get()
        {
            return Ok(products);
        }

        
    }
}
