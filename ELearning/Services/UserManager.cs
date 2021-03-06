using Eleaning_Web.Models;
using Eleaning_Web.Interface;
namespace Eleaning_Web.Services
{
    public class UserManager : IServiceUser
    {
        private readonly AltaContext _context;
        public UserManager(AltaContext context)
        {
            _context = context;
        }
        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList(); ;
        }
        public void Register(UserRequest request)
        {
            var user = new User
            {
                Email = request.Email,
                Password = request.Password,
                RoleId = request.RoleId,
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void Verify(string token)
        {
            throw new NotImplementedException();
        }
    }
}
