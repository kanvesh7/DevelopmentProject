using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sparcpoint.Business;
using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        IProductLogic _productLogic;
        ILogger _logger;
        public ProductController(IProductLogic productLogic, ILogger logger)
        {
            _productLogic = productLogic;
            _logger = logger;
        }

        // NOTE: Sample Action
        [HttpGet]
        public Task<IActionResult> GetAllProducts()
        {
            return Task.FromResult((IActionResult)Ok(new object[] { }));
        }

        /// <summary>
        /// Add a new Product to the DB
        /// </summary>
        /// <param name="products">Products</param> 
        /// <returns></returns>
        [HttpPost]
        public Task<IActionResult> AddProductDetails([FromBody] Products products)
        {
            _logger.LogDebug("Adding Products");
           return Task.FromResult((IActionResult)Ok(_productLogic.AddProductToDB(products))); 
        }

    }
}
