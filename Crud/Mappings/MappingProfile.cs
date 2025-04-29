using AutoMapper;
using Crud.Dtos;
using Crud.Entities;

namespace Crud.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeCreateDto, Employee>();
        }
    }
}
