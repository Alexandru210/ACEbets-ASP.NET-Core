using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ACEbets.Models
{
    public class BettingContext : IdentityDbContext<IdentityUser>
    {
        public BettingContext(DbContextOptions<BettingContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<BetStatus> BetsStatus { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
