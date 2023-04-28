using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BetService bettingContext) : base(bettingContext)
        {
        }
    }
}
