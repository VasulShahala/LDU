using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class Juge
    {
        public int Id { get; set; }

        public int DebaterId { get; set; }
        public Debater Debater { get; set; }


        public Raund Raund { get; set; }
        public double Rating { get; set; }
    }
}
