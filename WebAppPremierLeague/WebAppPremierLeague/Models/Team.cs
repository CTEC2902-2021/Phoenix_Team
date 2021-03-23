using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPremierLeague.Models
{
    public class Team
    {
        public virtual int TeamNo { get; set; }
        public virtual string TeamName { get; set; }
        public virtual string TeamManager { get; set; }
        public virtual int Draws { get; set; }
        public virtual int GoalDifference { get; set; }
        public virtual int GoalsAganist { get; set; }
        public virtual int GoalsFore { get; set; }
        public virtual int Losses { get; set; }
        public virtual int MatchesPlayed { get; set; }
        public virtual int NoOfPlayers { get; set; }
        public virtual int Wins { get; set; }

    }
}