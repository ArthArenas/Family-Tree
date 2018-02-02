using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFamilyTree_v1_1
{
	public class HistoricalEvent
	{
		public HistoricalEvent() { }
		public HistoricalEvent(string title, DateTime start, DateTime end)
		{
			this.title = title;
			this.start = start;
			this.end = end;
		}
		public DateTime start { get; set; }
		public DateTime end { get; set; }
		public string title { get; set; }
	}
}
