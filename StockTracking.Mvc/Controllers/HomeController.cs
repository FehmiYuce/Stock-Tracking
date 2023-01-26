using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using StockTracking.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing.Text;

namespace StockTracking.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //dependency injection için
        //private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger/*IProductService productService*/)
        {
            _logger = logger;
            //_productService = productService;
        }

        public IActionResult Index()
        {
            //var products = _productService.GetAll();
            //ProductManager pm = new ProductManager(new EfProductDal());
            //var products = pm.GetAll();
            return View();
		}

        public IActionResult Privacy()
        {
            return View();
        }
 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
      
    }
}