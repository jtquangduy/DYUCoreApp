using DYUCoreApp.Data.Entities;
using DYUCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYUCoreApp.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}