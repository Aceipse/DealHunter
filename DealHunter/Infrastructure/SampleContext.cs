using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DealHunter.Model;

namespace DealHunter.Infrastructure
{
    public class SampleContext : DbContext
    {
        public SampleContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<SampleContext>(new SampleSeedInitializer());
        }

        public DbSet<DealTrack> DealTracks { get; set; }
        
    }

    public class SampleSeedInitializer : DropCreateDatabaseIfModelChanges<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            var item = new DealTrack() { Name = "Works", Time = DateTime.Now};
            context.DealTracks.Add(item);
            context.SaveChanges();
        }
    }
}