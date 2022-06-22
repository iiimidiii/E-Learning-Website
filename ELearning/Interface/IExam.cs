using Eleaning_Web.DTO;
namespace Eleaning_Web.Interface
{
    public interface IExam
    {
        List<ExamDTO> GetAll();
        ExamDTO GetById(int ExamId);
        bool Insert(ExamDTO exam);
        bool Update(ExamDTO exam);
        bool Delete(int ExamId);
        void Save();
    }
}
