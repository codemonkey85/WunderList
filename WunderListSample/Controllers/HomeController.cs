using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WunderListSample.Models;
using Newtonsoft.Json;

namespace WunderListSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string str = System.IO.File.ReadAllText(@"F:\Project\WunderList\WunderListSample\File\data.txt");
            var data = JsonConvert.DeserializeObject<Rootobject>(str);

         

            return View();
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