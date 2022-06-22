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
    public class ClassController : Controller
    {
        private readonly IClass _class;
        private readonly IMapper _mapper;
        public ClassController(IClass classs, IMapper mapper)
        {
            _class = classs;
            _mapper = mapper;
        }
        //getall
        [HttpGet]
        public async Task<ActionResult<List<CLassDTO>>> GetAll()
        {
            var model = _class.GetAll();
            if (model == null)
            {
                return new List<CLassDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddClass(CLassDTO model)
        {
            var check = _class.Insert(model);
            _class.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateClass(CLassDTO classDTO)
        {
            var check = _class.Update(classDTO);
            _class.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteClass(string ClassId)
        {
            var check = _class.Delete(ClassId);

            _class.Save();
            return check;

        }
    }
}


