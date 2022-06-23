using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
namespace Eleaning_Web.Repository
{
    public class ResultRepository : IResults
    {
        private readonly IMapper admap;
        private readonly AltaContext con;


        public ResultRepository(AltaContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string ResultId)
        {
            var DeleteLearning = con.Results.Find(ResultId);
            if (DeleteLearning == null)
            {
                return false;
            }
            con.Remove(DeleteLearning);
            return true;
        }

        public List<ResultDTO> GetAll()
        {
            var Result = con.Results.ToList();
            return admap.Map<List<ResultDTO>>(Result);
        }



        public ResultDTO GetById(string LRId)
        {
            var byid = con.Results.Find(LRId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<ResultDTO>(byid);
        }

        public bool Insert(ResultDTO Result)
        {
            var insert = con.Results.Find(Result.ResultId);
            if (insert == null)
            {
                con.Results.Add(admap.Map<Result>(Result));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ResultDTO Result)
        {
            var Update = con.Results.Find(Result.ResultId);
            if (Update != null)
            {
                con.Results.Update(admap.Map(Result, Update));
                return true;
            }
            return false;
        }
    }
}