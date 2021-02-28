﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetCarsByBrandId(int id);
        List<Product> GetCarsByColorId(int id);
    }
}
