using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Chapter_5.Models
{
    public class FriendsContext : DbContext
    {
        public FriendsContext (DbContextOptions<FriendsContext> options)
            : base(options)
        {
        }

        public DbSet<Chapter_5.Models.Friends> Friends { get; set; }
    }
}
