using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Soba
    {
        public int SobaID { get; set; }
        [DisplayName("Naziv hotela")]
        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
        [Required]
        [DisplayName("Broj sobe")]
        public string BrojSobe { get; set; }
        [Required]
        [DisplayName("Tip sobe")]
        public string TipSobe { get; set; }
       
        public bool Zauzeta { get; set; }
        public override string ToString()
        {
            return $"{Hotel.Naziv} {BrojSobe} {TipSobe} {Zauzeta}";
        }
    }
}
