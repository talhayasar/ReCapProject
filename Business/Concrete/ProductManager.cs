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
        Bu program cs de newleyeceğimiz class. Bu class a IProductDal interfacesini 
        construct ettiğimiz için parametre olarak IProductDal vermemiz gerekecek.
        Ve IProductDal interfacesine _productDal dedik. _productDal'ı getall metodunda
        return ettik. Bu demek oluyorki verdiğimiz _productDal'ın getall metodu çalışacak.
        İşte bu da IProductDal'ı implemente eden classlardan herhangi birisi.
        Kısacası bir interfacedeki metodları farklı classlarda tanımlayıp,başka bir class'a
        intefaceyi construct edince onu implemente eden classlardan birini newleyip 
        parametre olarak vericez ve newlenen classın metodu çalışacak.Buradaki çalışacak
        classımız InMemoryProductDal.
        ----
         */
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> Getall()
        {
            return _productDal.Getall();
        }
    }
}
