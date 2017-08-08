using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class ActionDebater
    {
        public int Id { get; set; }
        public int TotalStars { get; set; }
        public double RiatStars { get; set; }
        public int GameCount { get; set; }


        public int DebaterId { get; set; }
        public Debater Debater { get; set; }

        
    }
}
