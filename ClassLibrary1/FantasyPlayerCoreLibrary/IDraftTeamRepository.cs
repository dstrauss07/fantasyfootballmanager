using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IDraftTeamRepository
    {
        List<DraftTeam> ListAllDraftTeams();
        List<PlayerDrafted> ListAllDraftedPlayers(int id);
        AuctionTeam GetDraftedTeamById(int id);
        void EditDraftedTeam(DraftTeam editedDraftTeam);
        void NewDraftedTeam(DraftTeam newDraftTeam);
        void DeleteDraftedTeam(int id);
    }
}
