namespace ACEbets.Models
{
    public class Bet
    {
        public int Id { get; set; }


        public Game? Game { get; set; }

        public float Amount { get; set; }

        public BetStatus? Status { get; set; }
    }

    public enum BetStatus
    {
        Pending,
        Won,
        Lost
    }
}
