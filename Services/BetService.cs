using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class BetService : BaseService
    {
        public BetService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }

        public List<Bet> GetBet()
        {
            return repositoryWrapper.BetRepository.FindAll().ToList();
        }

        public void AddBet(Bet bet)
        {
            repositoryWrapper.BetRepository.Create(bet);
        }

        public void UpdateBet(Bet bet)
        {
            repositoryWrapper.BetRepository.Update(bet);
        }

        public void DeleteBet(Bet bet)
        {
            repositoryWrapper.BetRepository.Delete(bet);
        }
    }
}
