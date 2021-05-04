using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPremierLeague.Models
{
    public class LeagueModel
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
    }
}