using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class GameService : BaseService
    {
        public GameService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
    }
}
