using AutoMapper;
using Eleaning_Web.DTO;
using Eleaning_Web.Interface;
using Eleaning_Web.Models;
namespace Eleaning_Web.Repository
{
    public class DocumentRepository : IDocument
    {
        private readonly IMapper admap;
        private readonly AltaContext con;


        public DocumentRepository(AltaContext context, IMapper mapper)
        {
            con = context;
            admap = mapper;
        }



        public bool Delete(int DocumentId)
        {
            var DeleteDocument = con.Documents.Find(DocumentId);
            if (DeleteDocument == null)
            {
                return false;
            }
            con.Remove(DeleteDocument);
            return true;
        }

        public List<DocumentDTO> GetAll()
        {
            var allDocument = con.Documents.ToList();
            return admap.Map<List<DocumentDTO>>(allDocument);
        }



        public DocumentDTO GetById(int DocumentId)
        {
            var byid = con.Documents.Find(DocumentId);
            if (byid == null)
            {
                return null;
            }

            return admap.Map<DocumentDTO>(byid);
        }

        public bool Insert(DocumentDTO document)
        {
            var insert = con.Documents.Find(document.DocumentId);
            if (insert == null)
            {
                con.Documents.Add(admap.Map<Document>(document));
                return true;
            }
            return false;
        }

        public void Save()
        {
            con.SaveChanges();
        }

        public bool Update(DocumentDTO document)
        {
            var Update = con.Documents.Find(document.DocumentId);
            if (Update != null)
            {
                con.Documents.Update(admap.Map(document, Update));
                return true;
            }
            return false;
        }
    }
}