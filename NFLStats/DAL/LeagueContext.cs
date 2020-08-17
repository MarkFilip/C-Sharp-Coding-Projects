using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NFLStats.Models;

namespace NFLStats.DAL
{
	public class LeagueContext : DbContext
	{
		public LeagueContext() : base("LeagueContext")
		{
		}

		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<Game> Games { get; set; }
		public DbSet<Statistic> Statistics { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}