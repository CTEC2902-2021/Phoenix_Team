using PremierLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremierLeague.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            LeagueModel league = new LeagueModel()
            {
                Title = "The Premier League",
                ByLine = "For all the latest Premier League news."
            };

            return View(league);
        }
    }
}