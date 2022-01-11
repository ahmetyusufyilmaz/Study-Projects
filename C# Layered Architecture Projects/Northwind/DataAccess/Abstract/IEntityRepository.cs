using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint (kısıtlama)
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        T Get();

        void Add(T entity);  // Interface methodları default public'tir.
        void Update(T entity);
        void Delete(T entity);
        Product Get(Expression<Func<Product, bool>> filter);
    }
}
