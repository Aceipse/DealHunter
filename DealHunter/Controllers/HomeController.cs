using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DealHunter.Infrastructure;
using DealHunter.Model;

namespace DealHunter.Controllers
{
    public class HomeController : Controller
    {
        private SampleContext _sampleContext;

        public HomeController()
        {
            _sampleContext = new SampleContext();
        }

        public ActionResult Index()
        {
            _sampleContext.DealTracks.Add(new DealTrack() { Name = "cake" });
            return View();
        }

        [HttpPost]
        public void Index(int a)
        {
            _sampleContext.DealTracks.Add(new DealTrack(){Name = "cake"});
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}