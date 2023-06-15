using Microsoft.AspNetCore.Mvc;
using Myproject01.Entities;
using Myproject01.Requests;
using Myproject01.Services;

namespace Myproject01.Controllers
{
    [ApiController]
    [Route("api/brand")]
    public class BrandController : Controller
    {
        public readonly IBrandService _service;
        public BrandController(IBrandService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public IActionResult Create(BrandRequest request) => Ok(_service.Create(request));
        [HttpDelete("Delete")]
        public IActionResult Delete(int requestId) => Ok(_service.Delete(requestId));
        [HttpGet("Get")]
        public  IActionResult GetById(int requestId) => Ok(_service.GetById(requestId));
        [HttpPut("update")]
        public IActionResult Update(BrandRequest id) => Ok(_service.Update(id));
    }
}
