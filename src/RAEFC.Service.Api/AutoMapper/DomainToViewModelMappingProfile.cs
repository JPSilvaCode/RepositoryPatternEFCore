using AutoMapper;
using RAEFC.Domain.Models;
using RAEFC.Service.Api.ViewModel;

namespace RAEFC.Service.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}