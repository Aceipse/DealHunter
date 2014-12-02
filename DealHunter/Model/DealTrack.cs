using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealHunter.Model
{
    public class DealTrack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }
    }
}