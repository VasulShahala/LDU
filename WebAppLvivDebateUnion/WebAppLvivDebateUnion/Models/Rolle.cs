using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class Rolle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Referense to users syst
        public List<Debater> Debaters { get; set; }
        
    }
}
