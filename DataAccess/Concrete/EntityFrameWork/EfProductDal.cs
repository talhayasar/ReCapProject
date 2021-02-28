using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (MyDataBaseContext context=new MyDataBaseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)//parametre lambda olacak
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }/*Get metodu bize birtane dönecek,default olarak filtresi null değil yani
              filtre verilmek zorunda. Verilen filteyi uygular ve single or default sayesinde 1 tane döner*/
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)//parametre lambda olacak
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
            /*filtre null ise direkt listeyi dön, değilse where'e filtreyi ver öyle dön.*/
        }

        public void Update(Product entity)
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
