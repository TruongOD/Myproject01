using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests.Params;
using Myproject01.Requests;

namespace Myproject01.Services
{
    public interface IBrandService
    {
        GenericResponse Create(BrandRequest request);

        GenericResponse Update(Brand request);

        GenericResponse Delete(int id);

        GenericResponse GetById(int id);

    }
}
