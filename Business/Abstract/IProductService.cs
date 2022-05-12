using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<ProductDetailDto> GetProductDetails();

        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<Product> GetById(int productId);
        void Update(Product produc);
        void Add(Product product);

    }
}
