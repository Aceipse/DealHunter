using System;
using System.Collections.Generic;
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
            
            return View();
        }

        [HttpPost]
        public void Index(int a)
        {
            
        }

	    [HttpGet]
	    public string GetHtml(string url)
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