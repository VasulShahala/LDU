using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ClubBornDate { get; set; }
        public string Location { get; set; }//Town  Univer
        public string Information { get; set; }//Info
        public string Path { get; set; } //Link to emblem club

        public List<Debater> Debaters { get; set; }
        
    }
}
