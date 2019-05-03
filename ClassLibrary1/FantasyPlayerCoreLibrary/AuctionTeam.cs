using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public class AuctionTeam
    {
        public int AuctionTeamId { get; set; }
        public bool IsPractice { get; set; }
        public bool IsComplete { get; set; }
        public int TeamSize { get; set; }
        public int StartingBudget { get; set; }
        public int RemainingBudget { get; set; }
        public List<PlayerAuctioned> AuctionedPlayers { get; set; }
    }
}
