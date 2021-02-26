using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> Getall();
        void Add(Color product);
        void Update(Color product);
        void Delete(Color product);
        List<Color> GetById(int Id);
    }
}
