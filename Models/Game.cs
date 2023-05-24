namespace ACEbets.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public DateTime GameDate { get; set; }
        public string Status { get; set; }
        public float HomeOdds { get; set; }

        public float AwayOdds { get;set; }

        public float DrawOdds { get; set; }

        public List<Bet>? Bets { get; set; }
    }
}
