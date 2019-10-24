using Microsoft.EntityFrameworkCore;
using Trendlog___Gruppe_2.Models;

namespace Trendlog___Gruppe_2.Data
{
    public class TrendlogContext : DbContext

    {
        public TrendlogContext (DbContextOptions<TrendlogContext> option)
            : base(option)
        {

        }
        public DbSet<Channel> Channels {get; set;}
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Point> Points { get; set; }
    }
}
