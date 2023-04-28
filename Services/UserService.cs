using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class UserService : BaseService
    {
        public UserService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
    }
}
