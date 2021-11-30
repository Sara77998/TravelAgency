using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Kalendar
    {
        [Required]
        public int KalendarID { get; set; }
        [Required]
        public string Dogadjaj { get; set; }
        [Required]
        public string Detalji { get; set; }
        [Required]
        public DateTime Pocetak { get; set; }
        
        public DateTime? Kraj { get; set; }
        [Required]
        public string Boja { get; set; }
        [Display(Name = "Traje ceo dan")]
        public bool CeoDan { get; set; }
    }
}
