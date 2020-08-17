using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NFLStats.Models;

namespace NFLStats.DAL
{
	public class LeagueInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<LeagueContext>
	{
		protected override void Seed(LeagueContext context)
		{
			var teams = new List<Team>
			{
				new Team{ID=1,Location="NY", Name="Giants",Conference=Conferences.NFC,Division=Divisions.East,},
				new Team{ID=2,Location="Philadelphia", Name="Eagles",Conference=Conferences.NFC,Division=Divisions.East,},
				new Team{ID=3,Location="Washington",Name="Football Team",Conference=Conferences.NFC,Division=Divisions.East,},
				new Team{ID=4,Location="Dallas",Name="Cowboys",Conference=Conferences.NFC,Division=Divisions.East,}
			};
			teams.ForEach(s => context.Teams.Add(s));
			context.SaveChanges();
			var players = new List<Player>
			{
				new Player{ID=1,FirstName="Saquon",LastName="Barkley",TeamID=1,Position=PositionType.RB,JerseyNumber=26, Picture="https://www.pro-football-reference.com/req/20180910/images/headshots/BarkSa00_2019.jpg" },
				new Player{ID=2,FirstName="Daniel",LastName="Jones",TeamID=1,Position=PositionType.QB,JerseyNumber=8, Picture="https://www.pro-football-reference.com/req/20180910/images/headshots/JoneDa05_2019.jpg" },
				new Player{ID=3,FirstName="Ezekiel",LastName="Elliot",TeamID=4,Position=PositionType.RB,JerseyNumber=21, Picture="https://www.pro-football-reference.com/req/20180910/images/headshots/ElliEz00_2019.jpg" },
				new Player{ID=4,FirstName="Dak",LastName="Prescott",TeamID=4,Position=PositionType.QB,JerseyNumber=4, Picture="https://www.pro-football-reference.com/req/20180910/images/headshots/PresDa01_2019.jpg" },

			};
			players.ForEach(s => context.Players.Add(s));
			context.SaveChanges();
			var games = new List<Game>
			{
				new Game{ID=1,HomeTeam="Cowboys", AwayTeam="Giants",Season=2019,Week=1,HomeScore=35,AwayScore=17, },
				new Game{ID=2,HomeTeam="Giants", AwayTeam="Cowboys",Season=2019,Week=6,HomeScore=18,AwayScore=37, }
			};
			games.ForEach(s => context.Games.Add(s));
			context.SaveChanges();
			var statistics = new List<Statistic>
			{
				new Statistic{ID=1,PlayerID=1,GameID=1,PassYds=0,PassTDs=0,RushTDs=0,RushYds=120,Receptions=4,RecYds=19,RecTDs=0},
				new Statistic{ID=2,PlayerID=1,GameID=2,PassYds=0,PassTDs=0,RushTDs=0,RushYds=28,Receptions=6,RecYds=67,RecTDs=0},
				new Statistic{ID=3,PlayerID=2,GameID=1,PassYds=17,PassTDs=0,RushTDs=0,RushYds=5,Receptions=0,RecYds=0,RecTDs=0},
				new Statistic{ID=4,PlayerID=2,GameID=2,PassYds=210,PassTDs=1,RushTDs=0,RushYds=54,Receptions=0,RecYds=0,RecTDs=0},
				new Statistic{ID=5,PlayerID=3,GameID=1,PassYds=0,PassTDs=0,RushTDs=1,RushYds=53,Receptions=1,RecYds=10,RecTDs=0},
				new Statistic{ID=6,PlayerID=3,GameID=2,PassYds=0,PassTDs=0,RushTDs=0,RushYds=139,Receptions=0,RecYds=0,RecTDs=0},
				new Statistic{ID=7,PlayerID=4,GameID=1,PassYds=405,PassTDs=4,RushTDs=0,RushYds=12,Receptions=0,RecYds=0,RecTDs=0},
				new Statistic{ID=8,PlayerID=4,GameID=2,PassYds=257,PassTDs=3,RushTDs=0,RushYds=12,Receptions=0,RecYds=0,RecTDs=0},
			};
			statistics.ForEach(s => context.Statistics.Add(s));
			context.SaveChanges();
		}
	}
}