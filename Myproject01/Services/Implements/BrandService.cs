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
            return new GenericResponse(true, 200, " tạo mới sản phẩm thành công", brand);
        }

        public GenericResponse Delete(int id)
        {
            var found = CheckDeleteSeriesNum(id);
            if (!found) return new GenericResponse(false, 401, "ID không tồn tại");
            var idDelete = _context.Brands.FirstOrDefault(b => b.Id == id);
            _context.Brands.Remove(idDelete);
            _context.SaveChanges();
            return new GenericResponse(true, 200, "xóa thành công");
        }

        public GenericResponse GetById(int id)
        {
            var found = CheckExistBrandId(id);
            if (!found) return new GenericResponse(false, 401, " Id bạn nhập không tồn tại sản phẩm");
            var reponse = new BrandRequest();

            var idResponse = _context.Brands.FirstOrDefault(x => x.Id == id);
            var product = _mapper.Map<Brand>(idResponse);
            return new GenericResponse(true, 200, " Sản phẩm của bạn yêu cầu thành công", product);
        }

        public GenericResponse Update(BrandRequest request)
        {
            var idUpdate = _context.Brands.Where(x => x.Id == request.Id).FirstOrDefault();
            if (idUpdate == null) return new GenericResponse(false, 401, "ID bạn nhập không tồn tại");
            request.Id = idUpdate.Id;
            request.Name = idUpdate.Name;
            request.ProductId =idUpdate.ProductId;
            request.Provider = idUpdate.Provider;
            request.Price = idUpdate.Price;

            _context.Brands.Update(idUpdate);
            _context.SaveChanges();
            return new GenericResponse(true, 200, "UPDATE thành công", idUpdate);
        }

        #region [private function helper]

        private bool CheckExistBrandName(string brandName) => _context.Brands.Any(x => x.Name == brandName);

        //private bool CheckExistSeriesNumOnUpdate(string seriesNum, int currentId) => _context.Brands.Any(x => x.SeriesNumber == seriesNum && x.Id != currentId);

        private bool CheckDeleteSeriesNum(int brandId) => _context.Brands.Any(x => x.Id == brandId);

        private bool CheckExistBrandId(int brandId) => _context.Brands.Any(x => x.Id == brandId);

        #endregion [private function helper]
    }
}