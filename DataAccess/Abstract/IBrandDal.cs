using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        List<Brand> Getall();
        void Add(Brand product);
        void Update(Brand product);
        void Delete(Brand product);
        List<Brand> GetById(int Id);
    }
}
