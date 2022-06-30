using Apidb.Entites;
using Apidblayer.Api;
using AutoMapper;

namespace Apidblayer.automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Teacher, TeacherApi>().ReverseMap(); ;
            CreateMap<Classes, Classeapi>().ReverseMap();
        }
    }
}
