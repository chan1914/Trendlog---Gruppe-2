using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.DataModel
{
	public enum Status
	{
		Pending,
		Completed,
		OnHold,
		InProgress
	}
	public class User
	{
		[Key]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string City { get; set; }
		public string ImagePath { get; set; }
		public Status Status { get; set; }
	}
}
