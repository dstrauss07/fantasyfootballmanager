using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options)
        {

        }

        public DbSet<AuctionTeam> AuctionTeam { get; set; }
        public DbSet<DraftTeam> DraftTeam { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<PlayerAuctioned> PlayerAuctioned { get; set; }
        public DbSet<PlayerDrafted> PlayerDrafted { get; set; }
        public DbSet<PlayerRanking> PlayerRanking { get; set; }
        public DbSet<TestUserProfile> TestUserProfile { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=aspnet-FantasyPlayerManager-99696E48-7E3D-4D6A-8DA4-15346F0F71A3;Trusted_Connection=True;MultipleActiveResultSets=true;");
        //}

    }
}
