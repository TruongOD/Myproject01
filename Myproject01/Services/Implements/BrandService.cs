using AutoMapper;
using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;

namespace Myproject01.Services.Implements
{
    public class BrandService : IBrandService
    {
        public readonly MyProjetContext _context;
        public readonly IMapper _mapper;

        public BrandService(MyProjetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse Create(BrandRequest request)
        {
            var found = CheckExistBrandName(request.Name);
            if (found) return new GenericResponse(false, 401, "Tên sản phầm này đã tồn tại");

            var brand = _mapper.Map<Brand>(request);
            brand.CreateDate = DateTime.Now;
            brand.Createdby = string.Empty;
            brand.UpdateDate = DateTime.Now;
            brand.Updatedby = string.Empty;
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return new GenericResponse(true, 200, " tạo mới sản phẩm thành công");

        }

        public GenericResponse Delete(int id)
        {
            throw new NotImplementedException();
        }

        public GenericResponse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GenericResponse Update(Brand request)
        {
            throw new NotImplementedException();
        }



        #region [private function helper]

        private bool CheckExistBrandName(string brandName) => _context.Brands.Any(x => x.Name == brandName);

        //private bool CheckExistSeriesNumOnUpdate(string seriesNum, int currentId) => _context.Brands.Any(x => x.SeriesNumber == seriesNum && x.Id != currentId);

        //private bool CheckDeleteSeriesNum(int seriesId) => _context.Brands.Any(x => x.BrandId == seriesId);

        #endregion [private function helper]
    }
}