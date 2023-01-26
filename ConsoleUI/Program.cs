using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.ComponentModel.Design.Serialization;
using System.Data.Common;

public class Program
{
    public static void Main(string[] args)
    {
        /*EfProductDal efProductDal= new EfProductDal();
        Product product = new Product();
        product.ProductId = 1;
        product.CategoryId = 1;
        product.BrandId = 1;
        product.ProductName = "Mouse";
        product.Barcode = "454543";*/

        //ProductManager productManager = new ProductManager(new EfProductDal());
        //foreach (var product in productManager.GetAll())
        //{
        //    Console.WriteLine(product.ProductName,product.ProductId,product.CategoryId,product.BrandId,product.Barcode);
        //}

        /*ProductManager pm = new ProductManager(new EfProductDal());
        pm.Add(new Product
        {
            CategoryId = 1,
            ProductId = 1,
            ProductName = "deneme",
            Barcode = "1651",
            BrandId = 1,
        });*/
        

    }
}