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
    public class DocumentController : ControllerBase
    {
        private readonly IDocument _document;
        private readonly IMapper _mapper;
        public DocumentController(IDocument document, IMapper mapper)
        {
            _document = document;
            _mapper = mapper;
        }
      
        [HttpGet]
        public async Task<ActionResult<List<DocumentDTO>>> GetAll()
        {
            var model = _document.GetAll();
            if (model == null)
            {
                return new List<DocumentDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddDocument(DocumentDTO model)
        {
            var check = _document.Insert(model);
            _document.Save();
            return check;

        }

        [HttpPut]
        public ActionResult<bool> UpdateDocument(DocumentDTO document)
        {
            var check = _document.Update(document);
            _document.Save();
            return check;

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteDocument(int DocumentId)
        {
            var check = _document.Delete(DocumentId);

            _document.Save();
            return check;

        }
    }
}