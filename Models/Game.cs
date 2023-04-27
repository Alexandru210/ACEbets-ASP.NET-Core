namespace ACEbets.Models
{
    public class Game
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float HomeOdds { get; set; }

        public float AwayOdds { get;set; }

        public float DrawOdds { get; set; }

        public ICollection<Bet>? Bets { get; set; }
    }
}
