using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class DebaterGameRaund
    {
        public int Id { get; set; }


        public int DebaterId { get; set; }
        public Debater Debater { get; set; }

        public int RaundId { get; set; }
        public Raund Raund { get; set; }
    }
}
