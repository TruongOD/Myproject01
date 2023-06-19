using Myproject01.Common.Constants;
using Myproject01.Requests;

namespace Myproject01.Services
{
    public interface IListWarehouseService 
    {
        GenericResponse GetListWareHouse(WareHouseResquest request);
    }
}
