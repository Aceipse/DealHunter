using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
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
            var myList = new ListOfDealTracks()
            {
                DealsTracks = new Collection<DealTrack>(),
                Owner = "Martin"
            };

            for (int i = 0; i < 10; i++)
            {
                myList.DealsTracks.Add(new DealTrack()
                {
                    Name = "Super Awesome Stuff",
                    Time = DateTime.Now,
                    Price = 9999,
                    Url = "https://www.komplett.dk/lenovo-z50-70-156-full-hd/825082"
                });
            }
            return View(myList);
        }

        [HttpPost]
        public void Index(int a)
        {
            
        }

	    [HttpGet]
	    public string GetHtml(string url, string toplel)
	    {
			var request = WebRequest.Create(url);
			var response = request.GetResponse();
			var reader = new StreamReader(response.GetResponseStream());

			string text = reader.ReadToEnd();
		    return text;
	    }

        public void GetPrice(string url)
        {
            ViewBag.URL = url;
        }

    }
}