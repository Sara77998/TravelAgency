using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        [Display(Name = "Agent")]
        [Required]
        public int AgentID { get; set; }
        public Agent Agent { get; set; }
        [Display(Name = "Soba")]
        [Required]      
        public int SobaID { get; set; }
        public Soba Soba { get; set; }
        [Display(Name = "Datum od")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumOd { get; set; }
        [Display(Name = "Datum do")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumDo { get; set; }
        public List<StavkaRezervacije> StavkeRezervacije{ get; set; }
    }
}
