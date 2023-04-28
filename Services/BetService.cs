using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class BetService : BaseService
    {
        public BetService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
    }
}
