using Eleaning_Web.Model;
using Eleaning_Web.Services;
namespace Eleaning_Web.Interface
{
    public interface IServiceUser
    {
        List<User> GetAllUser();
        void Register(UserRequest user);

        void Verify(string token);
        void ForgotPassword(string email);
    }
}
