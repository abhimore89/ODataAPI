using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Data;
using ODataAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataAPI.Controllers
{
   // [Route("api/v1/[controller]/")]
    public class ProductsController : ODataController
    {
        
        // GET: api/values

        
        [HttpGet]
        [EnableQuery()]
        public IActionResult Get()
        {
            return Ok(ProductData.products);
        }

        
    }
}
