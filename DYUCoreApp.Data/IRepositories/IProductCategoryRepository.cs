using DYUCoreApp.Data.Entities;
using DYUCoreApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace DYUCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}