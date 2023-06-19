using AutoMapper;
using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;

namespace Myproject01.Services.Implements
{
    public class WarehouseService : IWarehouseService
    {
        public readonly MyProjetContext _context;
        public readonly IMapper _mapper;

        public WarehouseService(MyProjetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse Create(WareHouseResquest request)
        {
            var found = CheckIdWareHouse(request.Id);
            if (found) return new GenericResponse(false, 401, "ID kho hàng bạn tạo mới đã bị trùng - Mời kiểm tra lại");

            var wareHouse = _mapper.Map<WareHouse>(request);
            wareHouse.CreateDate = DateTime.Now;
            wareHouse.UpdateDate = DateTime.Now;
            wareHouse.Createdby = string.Empty;
            wareHouse.Updatedby = string.Empty;
            _context.WareHouse.Add(wareHouse);
            _context.SaveChanges();
            return new GenericResponse(true, 200, " tạo mới kho hàng thành công", wareHouse);
        }

        public GenericResponse Delete(int id)
        {
            var found = CheckIdWareHouse(id);
            if (!found) return new GenericResponse(false, 401, "Kho hàng không tồn tại, nhập lại ID ");

            var idDelete = _context.WareHouse.FirstOrDefault(p => p.Id == id);
            _context.WareHouse.Remove(idDelete);
            _context.SaveChanges();
            return new GenericResponse(true, 200, " Xóa thành công");
        }

        public GenericResponse GetById(int id)
        {
            var found = CheckIdWareHouse(id);
            if (!found) return new GenericResponse(false, 401, " Kho bạn yêu cầu không tồn tại");

            var idWarehouse = _context.WareHouse.FirstOrDefault(x => x.Id == id);

            var warehouse = _mapper.Map<WareHouse>(idWarehouse);
            return new GenericResponse(true, 200, " Kho của bạn yêu cầu thành công", warehouse);
        }

        public GenericResponse Update(WareHouse request)
        {
            var found = CheckIdWareHouse(request.Id);
            if (!found) return new GenericResponse(true, 401, "ID kho hàng bạn nhập sai hoặc kho hàng này không có");
            var idUpdate = _context.WareHouse.Any(p => p.Id == request.Id);
            var warehouseUpdate = _mapper.Map<WareHouse>(request);

            _context.WareHouse.Update(warehouseUpdate);
            _context.SaveChanges(idUpdate);

            return new GenericResponse(true, 200, "update thành công", warehouseUpdate);
        }

        #region [funntion helper]

        public bool CheckIdWareHouse(int idWarehouse) => _context.WareHouse.Any(x => x.Id == idWarehouse);

        #endregion [funntion helper]
    }
}