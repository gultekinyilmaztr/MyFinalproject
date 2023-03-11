
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //herkes her t yi eklememesi için kısıt.IEntity olanilir veya ientity implemente eden bir nesne olabilir.
    // New'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity,new() 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Tüm liste yerine istenilen talebe göre listeleme

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        //List<T> GetAllByCategory(int categoryId); //ürünleri kategoriye göre listele Expression kulladığımız için asla bu koda ihtiyaç olmayacak.
    }
}
