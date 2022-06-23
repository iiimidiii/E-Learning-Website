using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IResults
    {
        List<ResultDTO> GetAll();
        ResultDTO GetById(string ResultId);
        bool Insert(ResultDTO Result);
        bool Update(ResultDTO Result);
        bool Delete(string ResultId);
        void Save();
    }
}
