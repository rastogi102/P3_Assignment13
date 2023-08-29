using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppTeam.Models
{
    
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int NOWC { get; set; }
    }
}