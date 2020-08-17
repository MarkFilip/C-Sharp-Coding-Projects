using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLStats.Models
{
	public enum PositionType
	{
		QB, RB, WR, TE
	}
	public class Player
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public PositionType Position { get; set; }
		public int JerseyNumber { get; set; }
		public int TeamID { get; set; }
		public string Picture { get; set; }

		public virtual ICollection<Statistic> Statistics { get; set; }
	}
}