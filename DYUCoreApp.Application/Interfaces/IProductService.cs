using DYUCoreApp.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using TeduCoreApp.Utilities.Dtos;

namespace DYUCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}