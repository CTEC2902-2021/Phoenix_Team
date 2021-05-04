using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppPremierLeague.Models
{
    public class TeamsModel : Controller
    {
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

        // GET: TeamsModel
        public ViewResult Team()
        {
            TeamsModel teamsmodel = new TeamsModel();
            teamsmodel.TeamName = "Man City";
            teamsmodel.TeamManager = "Steve Smith";
            teamsmodel.Wins = 10;

            if(teamsmodel.Wins > 20)
            {
                ViewBag.Subtitle = "This team has the Most Wins!";
            }
            else
            {
                ViewBag.Subtitle = "This team is Looking to get more wins";
            }

            return View(teamsmodel);
        }
    }
}