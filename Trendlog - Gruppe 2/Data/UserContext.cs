using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trendlog___Gruppe_2.DataModel;

namespace Trendlog___Gruppe_2.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<Trendlog___Gruppe_2.DataModel.User> User { get; set; }
    }
}
