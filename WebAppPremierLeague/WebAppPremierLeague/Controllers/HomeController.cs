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
        private List<clsTeams> _Teams = new List<clsTeams>
        {
            new clsTeams
            {
                TeamNo = 1,
                TeamManager = "Steve Smith",
                Wins = 7 },

            new clsTeams
            {
                TeamNo = 2,
                TeamManager = "Jeff",
                Wins = 12 },
            new clsTeams
            {
                TeamNo = 3,
                TeamManager = "Jon",
                Wins = 15 }

        };
            
        
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public int TeamNo { get; set; }
        public string TeamName { get; set; }
        public string TeamManager { get; set; }
        public int Draws { get; set; }
        public int GoalDifference { get; set; }
        public int GoalsAganist { get; set; }
        public int GoalsFore { get; set; }
        public int Losses { get; set; }
        public int MatchesPlayed { get; set; }
        public int NoOfPlayers { get; set; }
        public int Wins { get; set; }

        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Title = "The Premier League";
            ViewBag.WelcomeMessage = "For all the latest Premier League news.";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();



            //LeagueModel league = new LeagueModel()
            //{
            //   Title = "The Premier League",
            //  SubTitle = " For all the latest Premier League news.",

            //};

            // return View(league);
        }

        public ViewResult Teams()
        {
            TeamsModel teamsmodel = new TeamsModel();
            teamsmodel.TeamName = "Man City";
            teamsmodel.TeamManager = "Steve Smith";
            teamsmodel.Wins = 10;

            if(teamsmodel.Wins > 8)
            {
                ViewBag.Subtitle = "This teams has loads of wins";
            }
            else
            {
                ViewBag.Subtitle = "This teams is looking for more wins";
            }

            return View(teamsmodel);
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

        // GET: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            clsTeams selectedTeam = _Teams.First(p => p.TeamNo == id);

            if (selectedTeam == null) return new HttpNotFoundResult();
            return View(selectedTeam);
        }

    }
}