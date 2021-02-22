using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> Getall();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetById(int Id);
    }
}
