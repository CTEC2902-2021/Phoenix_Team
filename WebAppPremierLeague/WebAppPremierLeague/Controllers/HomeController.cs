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

        public ActionResult Teams()
        {
            ViewBag.Message = "Your premier league teams page.";


            return View();              
        }

        public ActionResult ManCity()
        {
            ViewBag.Message = "Manchester City team page.";


            return View();
        }

        public ActionResult ManUnited()
        {
            ViewBag.Message = "Manchester United team page.";


            return View();
        }

        public ActionResult LeicesterCity()
        {
            ViewBag.Message = "Leicester City team page.";


            return View();
        }

        public ActionResult Chelsea()
        {
            ViewBag.Message = "Chelsea team page.";


            return View();
        }

        public ActionResult WestHam()
        {
            ViewBag.Message = "West Ham team page.";


            return View();
        }

        public ActionResult Tottenham()
        {
            ViewBag.Message = "Tottenham team page.";


            return View();
        }

        public ActionResult Liverpool()
        {
            ViewBag.Message = "Liverpool team page.";


            return View();
        }

        public ActionResult Everton()
        {
            ViewBag.Message = "Everton team page.";


            return View();
        }

        public ActionResult Arsenal()
        {
            ViewBag.Message = "Arsenal team page.";


            return View();
        }

        public ActionResult AstonVilla()
        {
            ViewBag.Message = "Aston Villa team page.";


            return View();
        }

    }
}