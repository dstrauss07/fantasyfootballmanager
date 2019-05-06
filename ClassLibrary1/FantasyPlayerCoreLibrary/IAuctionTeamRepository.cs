using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IAuctionTeamRepository
    {
        List<AuctionTeam> ListAllAuctionTeams();
        List<PlayerAuctioned> ListAllAuctionedPlayers(int id);
        AuctionTeam GetAuctionTeamById(int id);
        void EditAuctionTeam(AuctionTeam editedAuctionTeam);
        void NewAuctionTeam(AuctionTeam newAuctionTeam);
        void DeleteAuctionTeam(int id);
    }
}
