using DYUCoreApp.Data.Entities;
using DYUCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}