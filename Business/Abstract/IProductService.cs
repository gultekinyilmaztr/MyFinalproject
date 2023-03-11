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
        List<Product> GetAll(); //bütün ürünleri listele

        List<Product>GetAllByCategoryId(int id);//Kategory Id ile tüm listeyi getir.

        List<Product> GetByUnitPrice(decimal min, decimal max);//şu fiyat aralığı ile tüm listeyi getir.

        List<ProductDetailDto> GetProductDetails();
    }
}
