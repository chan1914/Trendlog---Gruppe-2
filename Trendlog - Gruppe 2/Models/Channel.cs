using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trendlog___Gruppe_2.Models
{
    public class Channel
    {
        public int ChannelId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Timezone { get; set; }
        public int Lifetime { get; set; }
        public int Longitume { get; set; }
        public int Elevation { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int MaxSize { get; set; }
        public int PCount { get; set; }
        public List<Feed> FeedList { get; set; }



    }
}
