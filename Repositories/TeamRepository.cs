using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Repositories
{
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public TeamRepository(BetService bettingContext) : base(bettingContext)
        {
        }
    }
}
