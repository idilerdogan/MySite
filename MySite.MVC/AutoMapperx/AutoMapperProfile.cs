using AutoMapper;
using MySite.Entities.Entities.Concrete;
using MySite_MVC.Models.VMs;

namespace MySite_MVC.AutoMapperx
{

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<UserInsertVM, User>().ReverseMap();
        }
    }
}