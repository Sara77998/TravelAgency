using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public int AgentID { get; set; }
        public Agent Agent { get; set; }
        public int SobaID { get; set; }
        public Soba Soba { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public List<StavkaRezervacije> StavkeRezervacije{ get; set; }
    }
}
