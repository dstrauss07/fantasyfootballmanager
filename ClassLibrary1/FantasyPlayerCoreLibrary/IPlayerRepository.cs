using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
   public interface IPlayerRepository
    {
        List<Player> ListAllPlayers();
        List<Player> ListPlayersByPos(string pos);
        Player GetPlayerById(int id);
        void EditPlayer(Player editedPlayer);
        void NewPlayer(Player newPlayer);
        void DeletePlayer(int id);
    }
}
