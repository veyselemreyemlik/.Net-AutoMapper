using AutoMapper;
using LastDance.Dtos;
using LastDance.Models;

namespace LastDance.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, ResponseDTO>();
            CreateMap<RequestDTO, Employee>();
        }
    }
}
