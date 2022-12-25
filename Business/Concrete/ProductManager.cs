using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public Product Get(int id)
        {
            return _productDal.Get(p=>p.ProductId==id);
        }

        public IList<ProductDetailDto> GetAllByCategories()
        {
            var products = _productDal.GetAllByCategories();
            return (IList<ProductDetailDto>)products;
        }

        public void Delete(int id)
        {
            var deletedProduct = _productDal.Get(p=>p.ProductId==id);
            if (deletedProduct != null) 
            { 
                _productDal.Delete(deletedProduct);
            }
            else
            {
                
            }
        }

        public void Update(int id)
        {
            var updatedProduct = _productDal.Get(p=>p.ProductId==id);
            if (updatedProduct != null)
            {
                _productDal.Update(updatedProduct);
            }
            else
            {
                
            }
        }
    }
}
