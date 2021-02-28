using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.CarName);
            }
            //productManager.Add(new Product { CarName = "merco", DailyPrice = 2 ,BrandId=1,
            //    ColorId=2,Description="yeniaraba",Id=5,ModelYear=2000});
            //yeni araba ekledi gerçektende databasemize
        }
    }
}
