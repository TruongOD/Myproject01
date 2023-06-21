using AutoMapper;
using Myproject01.Common.Constants;
using Myproject01.Entities;
using Myproject01.Requests;
using Myproject01.Requests.Params;

namespace Myproject01.Services.Implements
{
    public class ProductSevice : IProductSevice
    {
        public readonly MyProjetContext _context;
        public readonly IMapper _mapper;

        public ProductSevice(MyProjetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region [ CREATE ]

        public GenericResponse Create(ProductRequest request)
        {
            var found = CheckExistSeriesNum(request.SeriesNumber);
            if (found) return new GenericResponse { };
            var product = _mapper.Map<Product>(request);

            product.CreateDate = DateTime.Now;
            product.Createdby = string.Empty;
            product.UpdateDate = DateTime.Now;
            product.Updatedby = string.Empty;
            _context.Products.Add(product);
            _context.SaveChanges();
            return new GenericResponse(true, 200, "thêm mới thành công");
        }

        #endregion [ CREATE ]

        public GenericResponse Delete(int id)
        {
            var found = CheckDeleteSeriesNum(id);
            if (!found) return new GenericResponse(false, 401, " Id của bạn cần xóa không tồn tại");
            var idDelete = _context.Products.FirstOrDefault(x => x.BrandId == id);
            _context.Products.Remove(idDelete);
            _context.SaveChanges();
            return new GenericResponse(true, 200, " Đã xóa thành công ");
        }

        public GenericResponse GetAll(BaseParam<ProductParams> request)
        {
            throw new NotImplementedException();
        }

        public GenericResponse GetById(int id)
        {
            
            var idResponse = _context.Products.FirstOrDefault(x => x.Id == id);
            //reponse.BrandId = idResponse.BrandId;
            //reponse.Id = idResponse.Id;
            //reponse.SeriesNumber = idResponse.SeriesNumber;
            //reponse.Provider = idResponse.Provider;
            //reponse.CreateDate = idResponse.CreateDate;
            //reponse.UpdateDate = idResponse.UpdateDate;
            //reponse.UpdateDate = idResponse.UpdateDate;
            var product = _mapper.Map<Product>(idResponse);
            return new GenericResponse(true, 200, "sản phẩm của bạn yêu cầu thành công", product);
        }

        public GenericResponse Update(Product request)
        {
            var idUpdate = _context.Products.Where(x => x.Id == request.Id).FirstOrDefault();
            if (idUpdate == null) return new GenericResponse(false, 401, "ID bạn nhập không tồn tại, không thể update");
            idUpdate.Id = request.Id;
            idUpdate.Name= request.Name;
            idUpdate.BrandId = request.BrandId;
            idUpdate.SeriesNumber = request.SeriesNumber;
            idUpdate.CreateDate = request.CreateDate;
            idUpdate.UpdateDate = request.UpdateDate;
            idUpdate.Createdby = request.Createdby;
            idUpdate.Updatedby = request.Updatedby;
            idUpdate.IsDeleted = request.IsDeleted;

            _context.Products.Update(idUpdate);
            _context.SaveChanges();
            return new GenericResponse(true, 200, "update thành công ", idUpdate);
        }

        #region [private function helper]

        private bool CheckExistSeriesNum(string seriesNum) => _context.Products.Any(x => x.SeriesNumber == seriesNum);

        private bool CheckExistSeriesNumOnUpdate(string seriesNum, int currentId) => _context.Products.Any(x => x.SeriesNumber == seriesNum && x.Id != currentId);

        private bool CheckDeleteSeriesNum(int deleteId) => _context.Products.Any(x => x.Id == deleteId);

        #endregion [private function helper]
    }
}