using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ShopProject_1.Models
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}