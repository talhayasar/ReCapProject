using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        /*
         ----
        Bu program.cs de newleyeceğimiz class. Bu class a IProductDal interfacesini 
        construct ettiğimiz için parametre olarak IProductDal vermemiz gerekecek.
        Ve IProductDal interfacesine _productDal dedik. _productDal'ı getAll metodunda
        return ettik. Bu demek oluyorki verdiğimiz _productDal'ın getall metodu çalışacak.
        İşte bu da IProductDal'ı implemente eden classlardan herhangi birisi.
        Kısacası bir interfacedeki metodları farklı classlarda tanımlayıp(entityframework yada ınmemory classları),
        başka bir class'a intefaceyi construct edince(bu class a ıproduct dal'ı ettik) 
        onu implemente eden classlardan birini newleyip 
        parametre olarak vericez ve newlenen classın metodu çalışacak.(IProductdal'ı implemente edenlerden
        birini newlicez ve  onun metodları çalışacak)
        ----
         */
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)//construct
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetCarsByBrandId(int id)
        {
            return _productDal.GetAll(p=>p.BrandId==id);
        }

        public List<Product> GetCarsByColorId(int id)
        {
            return _productDal.GetAll(p => p.ColorId == id);
        }
        /*Burada çağırılan tüm metodlar aslında ProductManager'a aittir. Sadece biz constructor
* olarak ıproductdal verdiğimiz için onun üzerinden metod çağırabiliyoruz.
örneğin GetCarsByBrandId metodu bu class'a özgü ama ıproductdal'dan çağırıp içine filte koyuyoruz.*/

    }
}
