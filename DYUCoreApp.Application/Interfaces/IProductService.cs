using DYUCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace DYUCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
    }
}