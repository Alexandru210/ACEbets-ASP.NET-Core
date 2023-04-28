namespace ACEbets.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IBetRepository BetRepository { get; }
        IGameRepository GameRepository { get; }
        ILog LogRepository { get; }
        ISportRepository SportRepository { get; }
        ITeamRepository TeamRepository { get; }
        IUserRepository UserRepository { get; }

        void Save();
    }
}
