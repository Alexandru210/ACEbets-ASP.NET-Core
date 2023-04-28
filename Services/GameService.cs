using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class GameService : BaseService
    {
        public GameService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
        public List<Game> GetGame()
        {
            return repositoryWrapper.GameRepository.FindAll().ToList();
        }

        public void AddBet(Game game)
        {
            repositoryWrapper.GameRepository.Create(game);
        }

        public void UpdateBet(Game game)
        {
            repositoryWrapper.GameRepository.Update(game);
        }

        public void DeleteBet(Game game)
        {
            repositoryWrapper.GameRepository.Delete(game);
        }
    }
}
