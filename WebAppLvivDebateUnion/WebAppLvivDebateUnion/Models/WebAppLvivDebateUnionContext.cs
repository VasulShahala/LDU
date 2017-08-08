using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppLvivDebateUnion.Models
{
    public class WebAppLvivDebateUnionContext : DbContext
    {
        public DbSet<ActionDebater> ActionDebaters { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubGroup> ClubGroups { get; set; }
        public DbSet<Debater> Debaters { get; set; }
        public DbSet<DebaterGameRaund> DebaterGameRaunds { get; set; }
        public DbSet<Juge> Judes { get; set; }
        public DbSet<Raund> Raunds { get; set; }
        public DbSet<Rolle> Rolles { get; set; }
        public DbSet<RolleGame> RolleGames { get; set; }




        public WebAppLvivDebateUnionContext(DbContextOptions<WebAppLvivDebateUnionContext> options)
            : base(options)
        {
        }

         
    }
    
}
