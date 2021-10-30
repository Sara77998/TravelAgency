using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class StavkaRezervacije
    {
        public int StavkaRezervacijeID { get; set; }
        public int RB { get; set; }
        public int GostID { get; set; }
        public Gost Gost { get; set; }
    }
}
