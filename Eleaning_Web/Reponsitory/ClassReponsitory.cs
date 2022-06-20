using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
namespace Eleaning_Web.Repository
{
    public class ClassRepository : Class
    {
        private readonly IMapper admap;
        private readonly AltaContext con;


        public ClassRepository(AltaContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }




        public List<CLassDTO> GetAll()
        {
            var allClass = con.Classes.ToList();
            return admap.Map<List<CLassDTO>>(allClass);
        }



        public CLassDTO GetById(string ClassId)
        {
            var byid = con.Classes.Find(ClassId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<CLassDTO>(byid);
        }

        public bool Insert(CLassDTO classDTO)
        {
            var insert = con.Classes.Find(classDTO.ClassId);
            if (insert == null)
            {
                con.Classes.Add(admap.Map<Class>(classDTO));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(CLassDTO classDTO)
        {
            var Update = con.Classes.Find(classDTO.ClassId);
            if (Update != null)
            {
                con.Classes.Update(admap.Map(classDTO, Update));
                return true;
            }
            return false;
        }
    }
}