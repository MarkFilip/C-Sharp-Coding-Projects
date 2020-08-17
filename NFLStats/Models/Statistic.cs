using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLStats.Models
{
	public class Statistic
	{
		public int ID { get; set; }
		public int PlayerID { get; set; }
		public int GameID { get; set; }
		public int PassYds { get; set; }
		public int RushYds { get; set; }
		public int RecYds { get; set; }
		public int Receptions { get; set; }
		public int PassTDs { get; set; }
		public int RushTDs { get; set; }
		public int RecTDs { get; set; }
	}
}