using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class BaseService
    {
        protected IRepositoryWrapper repositoryWrapper;

        public BaseService(IRepositoryWrapper repositoryWrapper) {
            this.repositoryWrapper = repositoryWrapper;
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
