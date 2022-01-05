using AutoMapper;
using DYUCoreApp.Application.ViewModels.Product;
using DYUCoreApp.Data.Entities;

namespace DYUCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}