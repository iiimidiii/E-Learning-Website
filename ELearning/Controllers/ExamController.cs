using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
using AutoMapper;
using Eleaning_Web.Repository;
using Eleaning_Web.DTO;

namespace Eleaning_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExam _exam;
        private readonly IMapper _mapper;
        public ExamController(IExam exams, IMapper mapper)
        {
            _exam = exams;
            _mapper = mapper;
        }
    
        [HttpGet]
        public async Task<ActionResult<List<ExamDTO>>> GetAll()
        {
            var model = _exam.GetAll();
            if (model == null)
            {
                return new List<ExamDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddExam(ExamDTO model)
        {
            var check = _exam.Insert(model);
            _exam.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateExam(ExamDTO exam)
        {
            var check = _exam.Update(exam);
            _exam.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteExam(int ExamId)
        {
            var check = _exam.Delete(ExamId);

            _exam.Save();
            return check;

        }
    }
}