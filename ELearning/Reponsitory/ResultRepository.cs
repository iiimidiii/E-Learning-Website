using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
namespace Eleaning_Web.Repository
{
    public class ResultRepository : Result
    {
        private readonly IMapper admap;
        private readonly AltaContext con;


        public ResultRepository(AltaContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(string LRId)
        {
            var DeleteLearning = con.Results.Find(LRId);
            if (DeleteLearning == null)
            {
                return false;
            }
            con.Remove(DeleteLearning);
            return true;
        }

        public List<ResultDTO> GetAll()
        {
            var allLearning = con.Results.ToList();
            return admap.Map<List<ResultDTO>>(allLearning);
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

        public bool Insert(ResultDTO learningResult)
        {
            var insert = con.Results.Find(learningResult.LRId);
            if (insert == null)
            {
                con.Results.Add(admap.Map<Result>(learningResult));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(ResultDTO learningResult)
        {
            var Update = con.Results.Find(learningResult.LRId);
            if (Update != null)
            {
                con.Results.Update(admap.Map(learningResult, Update));
                return true;
            }
            return false;
        }
    }
}