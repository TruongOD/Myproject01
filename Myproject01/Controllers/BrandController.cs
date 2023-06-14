using Microsoft.AspNetCore.Mvc;
using Myproject01.Entities;
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
        public IActionResult Create(Brand request) => Ok(_service.Create(request));
    }
}
