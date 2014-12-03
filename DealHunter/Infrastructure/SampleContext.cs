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
            //Database.SetInitializer<SampleContext>(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        public DbSet<DealTrack> DealTracks { get; set; }
        
    }

    
}