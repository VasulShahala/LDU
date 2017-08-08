using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class Debater
    {
        public int Id { get; set; }
        public string NameIP { get; set; }
        public DateTime BornDate { get; set; }
        public string CardNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FbLink { get; set; }
        public string VkLink { get; set; }
        public string Inform { get; set; }
        public bool Blocked { get; set; }
        public double Rating { get; set; }
        //Referense club
        public int ClubId { get; set; }
        public Club Club { get; set; }
        //Rolle referense
        public int RolleId { get; set; }
        public Rolle Rolle { get; set; }
        //Juge
        public Juge GameJuge { get; set; }
        //Action
        public ActionDebater DActionDebater { get; set; }

        public List<DebaterGameRaund> DebaterGameRaund { get; set; }

        public Debater()
        {
            DebaterGameRaund = new List<DebaterGameRaund>();
        }

        public RolleGame RolleInGame { get; set; }
    }
}
