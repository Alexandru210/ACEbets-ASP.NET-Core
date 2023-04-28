using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Repositories
{
    public class BetRepository : RepositoryBase<Bet>, IBetRepository
    {
        public BetRepository(BettingContext bettingContext) : base(bettingContext)
        {
        }
    }
}
