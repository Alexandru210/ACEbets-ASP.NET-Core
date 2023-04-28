using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class UserService : BaseService
    {
        public UserService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
        public List<User> GetBet()
        {
            return repositoryWrapper.UserRepository.FindAll().ToList();
        }

        public void AddBet(User user)
        {
            repositoryWrapper.UserRepository.Create(user);
        }

        public void UpdateBet(User user)
        {
            repositoryWrapper.UserRepository.Update(user);
        }

        public void DeleteBet(User user)
        {
            repositoryWrapper.UserRepository.Delete(user);
        }
    }
}
