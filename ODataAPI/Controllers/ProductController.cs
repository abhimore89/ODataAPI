using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataAPI.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductController : Controller
    {

        private readonly ProductContext productContext;

        public ProductController(ProductContext _productContext)
        {
            this.productContext = _productContext;
        }
     
        [HttpGet]
        public IActionResult GetAllProducts(int skip = 0, int limit=10)
        {
            return Ok(this.productContext.GetProducts().Skip(skip).Take(limit));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
