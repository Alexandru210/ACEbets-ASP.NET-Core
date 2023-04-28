using Microsoft.EntityFrameworkCore;

namespace ACEbets.Models
{
    public class BetService : DbContext
    {
        public BetService(DbContextOptions<BetService> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Bet> Bets { get; set; }
    }
}
