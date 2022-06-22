using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Models;
using Eleaning_Web.Repository;
namespace Eleaning_Web.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {


            this.CreateMap<CLassDTO, Class>();
            this.CreateMap<Class, CLassDTO>();

            this.CreateMap<DocumentDTO, Document>();
            this.CreateMap<Document, DocumentDTO>();

            this.CreateMap<ResultDTO, Result>();
            this.CreateMap<Result, ResultDTO>();

        }
         
       
    }
}
