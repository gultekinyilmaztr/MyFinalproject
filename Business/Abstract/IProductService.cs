using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); //bütün ürünleri listele // Ayrıca bana sanuçları da döndür.

        IDataResult<List<Product>> GetAllByCategoryId(int id);//Kategory Id ile tüm listeyi getir.

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);//şu fiyat aralığı ile tüm listeyi getir.

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);

        IResult Update(Product product);

        IResult AddTransactionalTest(Product product);
    }
}
