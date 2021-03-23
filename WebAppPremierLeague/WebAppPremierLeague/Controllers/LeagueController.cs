using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPremierLeague.Controllers
{
    public class LeagueController : Controller
    {
        // GET: League
        public ActionResult Index()
        {
            ViewBag.Title = "The Premier League";
            ViewBag.WelcomeMessage = "For all the latest Premier League news.";
            return View();
        }

        public string Team(int id)
        {
            return "Team: Id = " + id.ToString();
        }

    }
}