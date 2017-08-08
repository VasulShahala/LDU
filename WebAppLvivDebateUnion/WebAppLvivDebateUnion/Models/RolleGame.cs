using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class RolleGame
    {
        public int Id { get; set; }
        public string GameRolle { get; set; }

        public int DebaterId { get; set; }
        public Debater Debater { get; set; }
    }
}
