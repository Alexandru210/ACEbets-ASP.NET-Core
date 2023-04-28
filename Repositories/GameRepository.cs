using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Repositories
{
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(BetService bettingContext) : base(bettingContext)
        {
        }
    }
}
