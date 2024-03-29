﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.DataModel
{
	public class Author
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string ImagePath { get; set; }
		public int Earnings { get; set; }
	}
}
