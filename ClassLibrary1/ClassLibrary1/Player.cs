using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.PlayerLibrary
{
    public class Player
    {
        public int playerInt { get; set; }
        public string playerTeam { get; set; }
        public string playerImageName { get; set; } 
        public string playerName { get; set; }
        public string playerPos { get; set; }
        public int playerRank { get; set; }
        public int posRank { get; set; }
        public decimal playerValue{ get; set; }
        public int pprRank { get; set; }
        public int pprPosRank { get; set; }
        public decimal pprValue { get; set; }
        public int sflexRank { get; set; }
        public decimal sflexValue { get; set; }
        public int playerRiskLevel { get; set; }
    }
}
