using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=KanitPesindeDB; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Accussed1> Accusseds1 { get; set; }
        public DbSet<Accussed2> Accusseds2 { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DetectiveStory> DetectiveStories { get; set; }
        public DbSet<FindKiller> FindKillers { get; set; }
        public DbSet<Intro> Intros { get; set; }
        public DbSet<Investigation1> Investigations1 { get; set; }
        public DbSet<Investigation2> Investigations2 { get; set; }
        public DbSet<SceneOne> SceneOnes { get; set; }
        public DbSet<SceneTwo> SceneTwos { get; set; }
    }
}
