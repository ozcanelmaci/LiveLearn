using OnlineCourseManagement.Models.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineCourseManagement.Models.Core.DataAccess
{
    //generic constraint
    //class : reference tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı yani interface ler new'lenemez
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<T> GetAllByCategory(int categoryId); // bu koda ihtiyacımız kalmadı
    }
}
