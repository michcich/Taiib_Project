using AutoMapper;
using Gym.BLL.Dto;
using Gym.Model.Models;

namespace Gym.BLL_EF.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ClassDto, Class>().ReverseMap();
        }
    }
}
