using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class SportService : BaseService
    {
        public SportService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
    }
}
