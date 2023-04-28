using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Services
{
    public class TeamService : BaseService
    {
        public TeamService(IRepositoryWrapper repositoryWrapper) : base(repositoryWrapper)
        {
        }
        public List<Team> GetTeam()
        {
            return repositoryWrapper.TeamRepository.FindAll().ToList();
        }

        public void AddBet(Team team)
        {
            repositoryWrapper.TeamRepository.Create(team);
        }

        public void UpdateBet(Team team)
        {
            repositoryWrapper.TeamRepository.Update(team);
        }

        public void DeleteBet(Team team)
        {
            repositoryWrapper.TeamRepository.Delete(team);
        }
    }
}
