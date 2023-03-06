using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockTracking.Mvc.Models;

namespace StockTracking.Mvc.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Product()
        {
            //projede datatable nasıl kullanılır izle

            //var productValues = productManager.GetAll();
            return View("Index");
           
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
            //var newProduct = new ProductDetailDto();
            //newProduct.ProductName = productModel.ProductName;

            //ProductValidator productValidator = new ProductValidator();
            //ValidationResult results = productValidator.Validate(product);
            //if (results.IsValid)
            //{
            //    productManager.Add(product);
            //    return RedirectToAction("Product");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();

			productManager.Add(product);
			return RedirectToAction("Product");

		}
        //public PartialViewResult ProductPartial()
        //{
        //    return PartialView();
        //}
        
  //      public IActionResult AddProductDeneme()
  //      {
  //          return PartialView("AddProductPartial");
  //      }

  //      public IActionResult AddProductPartial()
  //      {
		//	//var jsonData = JsonConvert.SerializeObject(productManager.GetAll());
		//	//return Json(jsonData, new JsonSerializerSettings());
		//	var jsonData = productManager.GetAll();
		//	return Json(jsonData, new JsonSerializerSettings());
		//}

        public JsonResult GetProducts() 
        {
            //var jsonData = productManager.GetAll();
            var jsonData = productManager.GetAll();
			return Json(new { rows = jsonData, page = 1 }, new Newtonsoft.Json.JsonSerializerSettings());

		}
    }
}











// trirand- jqGrid. 
//partial view yap
//add ve update fonksiyonlarını birleştir. eğer ürün kayıtlıysa(ID 'a göre) güncellesin. kayıtlı değilse eklesin
//sayfayı yenilemesin, datatableyi yenilesin
