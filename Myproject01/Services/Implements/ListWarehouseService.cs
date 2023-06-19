using AutoMapper;
using Myproject01.Common.Constants;
using Myproject01.Requests;
using Myproject01.Responses;
using System.Linq;

namespace Myproject01.Services.Implements
{
    public class ListWarehouseService : IListWarehouseService
    {
        public readonly MyProjetContext _context;
        public readonly IMapper _mapper;

        public ListWarehouseService(MyProjetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse GetListWareHouse(WareHouseResquest request)
        {

            var response = new WarehouseResonses();
            var nameWarehouse = _context.WareHouse.FirstOrDefault(p => p.Id == request.Id && p.Location == request.Location);

            response.Name = request.Name;
            response.Location = request.Location;



            var listBrands = new List<BrandRequest>();

            foreach (var item in listBrands)
            {
                var product = _context.Products.FirstOrDefault();
                var brand = _context.Brands.FirstOrDefault();
                var brandRequest = new BrandRequest
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    ProductId = product.Id,
                    Quantity = brand.Quantity,
                    Price = product.Price,

                };
                listBrands.Add(brandRequest);
            }
            return new GenericResponse(true, 200, " ok", response);
            
           

            //if (nameWarehouse == null) return new GenericResponse(false, 401, " Mời bạn nhập lại tên kho");
        }
    }
}
