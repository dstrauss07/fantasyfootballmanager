using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public class PlayerRepositoryEF : IPlayerRepository
    {
        private readonly PlayerDbContext _playerDbContext;

        public PlayerRepositoryEF(PlayerDbContext playerDbContext)
        {
            _playerDbContext = playerDbContext;
        }

        public List<Player> ListAllPlayers()
        {
            return _playerDbContext.Player.ToList();
        }

        public Player GetPlayerById(int id)
        {
           return _playerDbContext.Player
                .Single(b => b.PlayerId == id);
        }

        public List<Player> ListPlayersByPos(string pos)
        {
            throw new NotImplementedException();
        }

        public void NewPlayer(Player newPlayer)
        {
            _playerDbContext.Add(newPlayer);
            _playerDbContext.SaveChanges();
        }


        public void EditPlayer(Player editedPlayer)
        {
            var OrigPlayer = GetPlayerById(editedPlayer.PlayerId);
            OrigPlayer.PlayerImageName = editedPlayer.PlayerImageName;
            OrigPlayer.PlayerName = editedPlayer.PlayerName;
            OrigPlayer.PlayerPos = editedPlayer.PlayerPos;
            OrigPlayer.PlayerTeam = editedPlayer.PlayerTeam;
            _playerDbContext.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            _playerDbContext.Remove(GetPlayerById(id));
            _playerDbContext.SaveChanges();
        }




    }
}
