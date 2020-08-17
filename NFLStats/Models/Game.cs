using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLStats.Models
{
	public class Game
	{
		public int ID { get; set; }
		public string HomeTeam { get; set; }
		public string AwayTeam { get; set; }
		public int Week { get; set; }
		public int Season { get; set; }
		public int HomeScore { get; set; }
		public int AwayScore { get; set; }
	}
}