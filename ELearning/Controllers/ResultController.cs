using Microsoft.AspNetCore.Mvc;
using Eleaning_Web.Services;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
using AutoMapper;
using Eleaning_Web.Repository;
using Eleaning_Web.DTO;
using Microsoft.AspNetCore.Http;
using ELearning.Interface;

namespace Eleaning_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly Interface.IResult _leaR;
        private readonly IMapper _mapper;
        public ResultController(Interface.IResult learningResult, IMapper mapper)
        {
            _leaR = learningResult;
            _mapper = mapper;
        }
 
        [HttpGet]
        public async Task<ActionResult<List<ResultDTO>>> GetAll()
        {
            var learningResult = _leaR.GetAll();
            if (learningResult == null)
            {
                return new List<ResultDTO>();
            }
            return learningResult.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddLearning(ResultDTO learningResult)
        {
            var check = _leaR.Insert(learningResult);
            _leaR.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateLearning(ResultDTO learningResult)
        {
            var check = _leaR.Update(learningResult);
            _leaR.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteLearning(string LRId)
        {
            var check = _leaR.Delete(LRId);

            _leaR.Save();
            return check;

        }
    }
}