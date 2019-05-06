using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IPlayerAuctioned
    {

        List<PlayerAuctioned> ListAllPlayerAuctioned();
        PlayerAuctioned GetPlayerAuctionedById(int id);
        void EditPlayerAuctioned(PlayerAuctioned editedPlayerAuctioned);
        void NewPlayerAuctioned(PlayerAuctioned newPlayerAuctioned);
        void DeletePlayerAuctioned(int id);
    }
}
