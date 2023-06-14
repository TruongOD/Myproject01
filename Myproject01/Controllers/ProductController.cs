using Microsoft.AspNetCore.Mvc;
using Myproject01.Entities;
using Myproject01.Requests;
using Myproject01.Services;

namespace Myproject01.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : Controller
    {
        public readonly IProductSevice _sevice;
        public ProductController(IProductSevice sevice)
        {
            _sevice = sevice;
        }
        [HttpPost("Create")]
        public IActionResult Create(ProductRequest request) => Ok(_sevice.Create(request));
        [HttpDelete("Delete")]
        public IActionResult Delete(int request) => Ok(_sevice.Delete(request));
        [HttpGet("Get")]
        public IActionResult GetById(int id) => Ok(_sevice.GetById(id));
        [HttpPut("update")]
        public IActionResult UpdateById(Product id)
        {
            var data = _sevice.Update(id);
            return Ok(data);
        }
    }
}
