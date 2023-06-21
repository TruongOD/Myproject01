using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;

namespace Myproject01.Services
{
    public interface IWarehouseService
    {
        GenericResponse Create(WareHouseResquest request);

        GenericResponse Update(WareHouse request);

        GenericResponse Delete(int id);

        GenericResponse GetById(int id);
                
    }
}
