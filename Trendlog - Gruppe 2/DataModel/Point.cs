using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.DataModel
{
	public class Point
	{
		[Key]
		public int ID { get; set; }
		public DateTime Timestamp { get; set; }
		public long Value { get; set; }

	}
}
