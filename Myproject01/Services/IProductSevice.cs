using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;
using Myproject01.Requests.Params;

namespace Myproject01.Services
{
    public interface IProductSevice
    {
        GenericResponse Create(ProductRequest request);

        GenericResponse Update(Product request);

        GenericResponse Delete(int id);

        GenericResponse GetById(int id);

        GenericResponse GetAll(BaseParam<ProductParams> request);
    }
}