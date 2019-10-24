using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.Models
{
    public class Feed
    {
        public int FeedId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public int Scale { get; set; }
        public int Alarm { get; set; }
        public Boolean EnableAlarm { get; set; }
        public string AlarmSettings { get; set; }
        public List<Point> Points { get; set; }
    }
}
