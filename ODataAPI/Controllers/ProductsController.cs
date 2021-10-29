using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Data;
using ODataAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataAPI.Controllers
{
    [Route("api/v1/[controller]/")]
    public class ProductsController : Controller
    {

        private readonly ProductContext productContext;

        public ProductsController(ProductContext _productContext)
        {
            this.productContext = _productContext;
        }


        // GET: api/values


        //[HttpGet]
        //[EnableQuery()]
        //public IActionResult Get()
        //{
        //    return Ok(this.productContext.GetProducts());
        //}


        [HttpGet]
        public IActionResult GetAllProducts(int skip = 0, int limit = 10)
        {
            var products = this.productContext.GetProducts().Skip(skip).Take(limit);
            if (products != null && products.Any())
            {
                return Ok(products);
            }

            return NoContent();

        }



        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {

            var product = this.productContext.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }

            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                return BadRequest("Product Name cannot be empty");
            }

            else if (string.IsNullOrEmpty(product.Category))
            {
                return BadRequest("Product Category cannot be empty");
            }



            var productInfo = this.productContext.AddProduct(product);

            return StatusCode(201);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                return BadRequest("Product Name cannot be empty");
            }

            else if (string.IsNullOrEmpty(product.Category))
            {
                return BadRequest("Product Category cannot be empty");
            }


            this.productContext.UpdateProduct(product, id);
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool isArchived = this.productContext.ArchiveProduct(id);
            if (isArchived)
            {
                return NoContent();
            }

            return NotFound();
        }

    }
}
