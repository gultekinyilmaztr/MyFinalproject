using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product>? _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak",UnitPrice=15, UnitsInStock=15 },
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera",UnitPrice=15, UnitsInStock=3 },
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon",UnitPrice=15, UnitsInStock=2 },
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye",UnitPrice=15, UnitsInStock=65 },
                new Product{ProductId=5, CategoryId=2, ProductName="Fare",UnitPrice=15, UnitsInStock=1 },          
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //lambda

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);

            //SingleOrDefault metodu döngü ile tekrar tekrar dönmesi yerine direk id yi bulan hızlı bir metod.
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList(); //where komutu şarta uyan elenanları yeni bir liste haline geririp döndürür.
            
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan ürün id'sini bul
            Product productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName= product.ProductName;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
