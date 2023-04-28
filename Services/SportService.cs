using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class SportService : BaseService
    {
        public SportService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
        public List<Sport> GetSport()
        {
            return repositoryWrapper.SportRepository.FindAll().ToList();
        }

        public void AddBet(Sport sport)
        {
            repositoryWrapper.SportRepository.Create(sport);
        }

        public void UpdateBet(Sport sport)
        {
            repositoryWrapper.SportRepository.Update(sport);
        }

        public void DeleteBet(Sport sport)
        {
            repositoryWrapper.SportRepository.Delete(sport);
        }
    }
}
