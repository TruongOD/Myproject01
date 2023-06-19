using Microsoft.AspNetCore.Mvc;
using Myproject01.Entities;
using Myproject01.Requests;
using Myproject01.Services;

namespace Myproject01.Controllers
{
    [ApiController]
    [Route("API/warehouse")]
    public class WarehouseController : Controller
    {
        public readonly IWarehouseService _service;
        public readonly IListWarehouseService _listService;
        public WarehouseController(IWarehouseService service, IListWarehouseService listService)
        {
            _service = service;
            _listService = listService;
        }
        [HttpPost("Create")]
        public IActionResult Create(WareHouseResquest reuquest) => Ok(_service.Create(reuquest));
        [HttpDelete("DELETE")]
        public IActionResult Delete(int idRequest) => Ok(_service.Delete(idRequest));
        [HttpGet("GET")]    
        public IActionResult GetById(int idRequest) => Ok(_service.GetById(idRequest));
        [HttpPut("PUT")]    
        public IActionResult Update(WareHouse request) =>Ok(_service.Update(request));


        [HttpGet("GET")]
        public IActionResult GetbyId(WareHouseResquest request) => Ok(_listService.GetListWareHouse(request));
    }
}
