namespace ACEbets.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public decimal Amount { get; set; }
        public BetStatus Status { get; set; }
    }
}