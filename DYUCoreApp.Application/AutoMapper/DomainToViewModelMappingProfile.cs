using AutoMapper;
using DYUCoreApp.Application.ViewModels.Product;
using DYUCoreApp.Application.ViewModels.System;
using DYUCoreApp.Data.Entities;

namespace DYUCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();

            CreateMap<Function, FunctionViewModel>();
        }
    }
}