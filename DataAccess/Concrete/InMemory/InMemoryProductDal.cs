using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        /*Global bir _product adında liste tanımladık.Bu normalde veri tabanından gelicek
         Bunu bir constructor içinde tanımlayarak InMemoryProductDal referansı çağırıldığı an
        bu listenin oluşmasını sağlıyoruz*/
        public InMemoryProductDal()
        {
            _products = new List<Product> {
               new Product{Id=1,BrandId=1,ColourId=1,DailyPrice=1000,ModelYear=2015,Description="Öğretmenden satılık temiz 2.El Corolla" },
               new Product{Id=2,BrandId=2,ColourId=1,DailyPrice=2000,ModelYear=2020,Description="Doktordan satılık temiz 2.El Avensis" },
               new Product{Id=3,BrandId=1,ColourId=2,DailyPrice=5000,ModelYear=2021,Description="Galeriden satılık sıfır 3008" }
            };
        }
        public void Add(Product product)
        {/*Add fonksiyonu bizim global olan _product listemize bu fonksiyona verilen product
          objesini ekleyecek*/
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.Id==product.Id);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getall()
        {
            return _products;//herhangi bi parametre verilmicek.Direkt return edicek bize
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetById(int Id)//liste dönücek
        {
            return _products.Where(p=>p.Id==Id).ToList();/*where metodu IEnumarable döner
            onu da ToList ile listeye çevirip return ettik*/
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=>p.Id==product.Id);
            productToUpdate.ColourId = product.ColourId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;
            /*Burada _product listesindeki Id ile parametrenin Id si eşit olunca
             adresini pdoductToUpdateye atıyoruz ardırdan güncelliyoruz*/
        }
    }
}
