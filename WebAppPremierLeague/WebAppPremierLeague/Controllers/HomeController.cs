using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPremierLeague.Models;

namespace WebAppPremierLeague.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            LeagueModel league = new LeagueModel()
            {
                Title = "The Premier League",
                SubTitle = " For all the latest Premier League news.",

            };

            return View(league);
        }
    }
}