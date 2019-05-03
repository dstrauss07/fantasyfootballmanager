using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public class TestUserProfile
    {
        public int TestUserProfileId { get; set;}
        public string Name { get; set;}
        public string UserEmail { get; set;}
        public List<AuctionTeam> AuctionTeams { get; set; }
        public List<DraftTeam> DraftTeams { get; set; }
        public List<PlayerRanking> PlayerRankings { get; set; }
    }
}
