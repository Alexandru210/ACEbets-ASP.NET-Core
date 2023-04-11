namespace ACEbets.Models
{
    public class Game
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        //public Team? HomeTeam { get; set; }

        //public Team? AwayTeam { get; set; }

        //public decimal HomeOdds { get; set; }

        //public decimal AwayOdds { get;set; }

        //public decimal DrawOdds { get; set; }

        public ICollection<Bet>? Bets { get; set; }
    }
}
