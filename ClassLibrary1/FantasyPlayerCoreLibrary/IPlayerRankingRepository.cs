using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IPlayerRankingRepository
    {
        List<PlayerRanking> ListAllPlayerRankings();
        List<PlayerRanking> ListAllPlayerRankingsByPos(string pos);
        Player GetPlayerRankingById(int id);
        void EditPlayerRanking(PlayerRanking editedPlayerRanking);
        void NewPlayerRanking(PlayerRanking newPlayerRanking);
        void DeletePlayerRanking(int id);
    }
}
