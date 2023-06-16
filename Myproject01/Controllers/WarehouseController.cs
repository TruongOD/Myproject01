using Microsoft.AspNetCore.Mvc;
using Myproject01.Requests;
using Myproject01.Services;

namespace Myproject01.Controllers
{
    [ApiController]
    [Route("API/warehouse")]
    public class WarehouseController : Controller
    {
        public readonly IWarehouseService _service;
        public WarehouseController(IWarehouseService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public IActionResult Create(WareHouseResquest reuquest) => Ok(_service.Create(reuquest));
        [HttpDelete("DELETE")]
        public IActionResult Delete(int idRequest) => Ok(_service.Delete(idRequest));
        [HttpGet("GET")]    
        public IActionResult GetById(int idRequest) => Ok(_service.GetById(idRequest));

    }
}
