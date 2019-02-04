using AutoMapper;
using WebAPITemplate.Models;

namespace WebAPITemplate
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SampleModel, Response>()
                .ForMember(vm => vm.Message, map => map.MapFrom(m => m.Message));
        }
    }
}