using Microsoft.Build.Framework;

namespace ACEbets.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public decimal Amount { get; set; }
        public List<Game> Games { get; set; }
        public BetStatus Status { get; set; }
        public DateTime IssueDate { get; set; }
    }
}