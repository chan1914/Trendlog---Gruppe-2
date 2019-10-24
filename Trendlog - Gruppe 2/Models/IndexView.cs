using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.Models
{
	public class IndexView
	{
		public class IndexViewModel
		{
			public int TotalOrders { get; set; }
			public int ClientProfit { get; set; }
			public int PeopleInterestRate { get; set; }
			public string TotalRevenueStreamsRounded { get; set; }
			public int GeneratedLeadsProcent { get; set; }
			public int SubmittedTickersProcent { get; set; }
			public int ServerAllocationProcent { get; set; }
			public int TotalExpectedIncome { get; set; }
			public int TotalExpectedIncomeProcent { get; set; }
			//public IEnumerable<Author> Authors { get; set; }
			//public IEnumerable<User> Users { get; set; }
		}
	}
}
