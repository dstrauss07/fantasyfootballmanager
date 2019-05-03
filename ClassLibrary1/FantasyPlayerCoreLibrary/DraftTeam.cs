using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public class DraftTeam
    {
        public int DraftTeamId { get; set; }
        public bool IsPractice { get; set; }
        public bool IsCompleted { get; set; }
        public int TeamSize { get; set; }
        public string ScoringFormat { get; set; }
        public List<PlayerDrafted> DraftedPlayers { get; set; }
   }
}
