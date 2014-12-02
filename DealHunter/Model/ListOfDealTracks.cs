using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealHunter.Model
{
    public class ListOfDealTracks
    {
        public ListOfDealTracks()
        {
            this.DealsTracks = new HashSet<DealTrack>();
        }
        public int Id { get; set; }
        public string Owner { get; set; }           
        public virtual ICollection<DealTrack> DealsTracks { get; set; }
    }
}