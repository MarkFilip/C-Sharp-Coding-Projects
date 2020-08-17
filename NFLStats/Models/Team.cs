using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLStats.Models
{
	public enum Conferences
	{
		AFC, NFC
	}
	public enum Divisions
	{
		North, South, East, West
	}
	public class Team
	{
		public int ID { get; set; }
		public string Location { get; set; }
		public string Name { get; set; }
		public Conferences Conference { get; set; }
		public Divisions Division { get; set; }

		public virtual ICollection<Player> Players { get; set; }
		public virtual ICollection<Game> Games { get; set; }
	}
}