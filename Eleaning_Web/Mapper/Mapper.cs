using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Models;
using Eleaning_Web.Repository;
namespace Eleaning_Web.Mapper
{
    public class Mapper : Profile
    {
        public mapper()
        {


            this.CreateMap<CLassDTO, Class>();
            this.CreateMap<Class, CLassDTO>();



        }
         
       
    }
}
