using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLvivDebateUnion.Models
{
    public class Raund
    {
        public int Id { get; set; }
        public DateTime GameDate {get;set;}
        public string RaundNumb { get; set; } //Format 1/1
        public string Resolution { get; set; }
        public string Format { get; set; }//Brit / Amer
        public string StatLevel { get; set; }//Серйозність: фан, серйозна
       

        
        public int JugeId { get; set; }
        public Juge Juge { get; set; }



        public List<DebaterGameRaund> DebaterGameRaund { get; set; }

        public Raund()
        {
            DebaterGameRaund = new List<DebaterGameRaund>();
        }
    }
}
/*Місце 1У (якщо є)
Місце 1О (якщо є)
Місце 2У (відсутній у американці)
*/