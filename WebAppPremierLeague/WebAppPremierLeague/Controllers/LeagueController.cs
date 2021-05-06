using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppPremierLeague.Models;
using WebAppPremierLeague.Controllers;

namespace WebAppPremierLeague.Controllers
{
    public class LeagueController : Controller
    {
        private TeamsModel _model;
        public LeagueController(HomeController model1) { }
        public LeagueController(TeamsModel model)
        {
            _model = model;
        }

        // GET: League
        public ViewResult Index()
        {
            ViewBag.Title = "The Premier League";
            ViewBag.WelcomeMessage = "For all the latest Premier League news.";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }

        public ViewResult Team()
        {
            if(_model.Wins > 10)
            {
                ViewBag.Subtitle = "This team has the Most Wins!";
            }
            else
            {
                ViewBag.Subtitle = "This team is Looking to get more wins";
            }

            return View(_model);
        }
         
            

public string Team(int id)
        {
            return "Team: Id = " + id.ToString();
        }

    }
}