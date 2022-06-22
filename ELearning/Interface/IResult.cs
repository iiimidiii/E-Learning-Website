using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IResult
    {
        List<ResultDTO> GetAll();
        ResultDTO GetById(string LRId);
        bool Insert(ResultDTO learningResult);
        bool Update(ResultDTO learningResult);
        bool Delete(string LRId);
        void Save();
    }
}
