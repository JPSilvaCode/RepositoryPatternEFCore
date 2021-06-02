using AutoMapper;
using RAEFC.Domain.Models;
using RAEFC.Service.Api.ViewModel;

namespace RAEFC.Service.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}