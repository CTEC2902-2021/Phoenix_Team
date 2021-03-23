using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPremierLeague.Models
{
    public class Players
    {
        public virtual int PlayerNo { get; set; }
        public virtual string PlayerName { get; set; }
        public virtual int JerseryNumber { get; set; }
        public virtual int NoOfFans { get; set; }
        
    }
}