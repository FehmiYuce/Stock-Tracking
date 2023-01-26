using Core.DateAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, StockTrackingContext>, IProductDal
    {
        //using(StockTrackingContext context=new StockTrackingContext)
        // {

        // var bringTogether = from d1 in context.Products
        //                     join d2 in context.Categories
        //                     on d1.CategoryId equals d2.CategoryId
        //                     select new
        //                     {
        //                         ProductId = d1.ProductId,
        //                         ProductName = d1.ProductName,
        //                         CategoryName = d2.CategoryName,
        //                     };
        // }
        public ICollection<Product> GetAllByCategories()
        {
            using (StockTrackingContext _db = new StockTrackingContext())
            {
                var query = from p in _db.Products
                            join c in _db.Categories
                            on p.CategoryId equals c.CategoryId
                            select new ProductDetailDto
                            {
                                ProductName = p.ProductName,
                                CategoryName = c.CategoryName,
                                Barcode = p.Barcode,
                                UnitPrice= p.UnitPrice,
                                UnitInStock= p.UnitInStock,
                            };
                return (ICollection<Product>)query.ToList();
            }
        }
    }
}
