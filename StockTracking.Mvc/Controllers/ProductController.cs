using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using StockTracking.Mvc.Models;

namespace StockTracking.Mvc.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Product()
        {
            //projede datatable nasıl kullanılır izle

            var productValues = productManager.GetAll();
            return View("Index",productValues);
           
        }
        //public IActionResult GetProductList()
        //{

        //    return PartialView();
        //}
        [HttpGet]  //sayfa yüklendiği zaman çalışır
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]  //sayfada bir butona tıkladığımızda yani post edildiğinde çalışacağı anlamına geliyor
        public IActionResult AddProduct(Product product)
        {
            //productManager.Add(product);
            ProductValidator productValidator = new ProductValidator();
            ValidationResult results = productValidator.Validate(product);
            if (results.IsValid)
            {
                productManager.Add(product);
                return RedirectToAction("Product");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
// trirand- jqGrid. 
//partial view yap
//add ve update fonksiyonlarını birleştir. eğer ürün kayıtlıysa(ID 'a göre) güncellesin. kayıtlı değilse eklesin
//sayfayı yenilemesin, datatableyi yenilesin
