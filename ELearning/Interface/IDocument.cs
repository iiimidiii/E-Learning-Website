using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IDocument
    {
        List<DocumentDTO> GetAll();
        DocumentDTO GetById(int DocumentId);
        bool Insert(DocumentDTO document);
        bool Update(DocumentDTO document);
        bool Delete(int DocumentId);
        void Save();
    }
}
