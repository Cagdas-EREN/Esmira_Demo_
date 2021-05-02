using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EsmiraContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (EsmiraContext context = new EsmiraContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.Id
                    select new ProductDetailDto
                    {
                        Id = p.Id,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                    };
                return result.ToList();
            }
        }
    }
}
