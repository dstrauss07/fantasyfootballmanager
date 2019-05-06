using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IPlayerDrafted
    {
        List<PlayerDrafted> ListAllPlayerDrafted();
        PlayerDrafted GetPlayerDraftedById(int id);
        void EditPlayerDrafted(PlayerDrafted editedPlayerDrafted);
        void NewPlayerDrafted(PlayerDrafted newPlayerDrafted);
        void DeletePlayerDrafted(int id);
    }
}
