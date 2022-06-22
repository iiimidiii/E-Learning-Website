using Eleaning_Web.DTO;
namespace ELearning.Interface
{
    public interface IClass

    {
        List<CLassDTO> GetAll();
        CLassDTO GetById(string ClassId);
        bool Insert(CLassDTO classDTO);
        bool Update(CLassDTO classDTO);
        bool Delete(string ClassId);
        void Save();
    }
}
