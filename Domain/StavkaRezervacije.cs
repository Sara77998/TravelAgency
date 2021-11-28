using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StavkaRezervacije
    {
        public int RezervacijaID { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public int StavkaRezervacijeID { get; set; }
        
        public int RB { get; set; }
        
        public int GostID { get; set; }
        public Gost Gost { get; set; }
    }
}
