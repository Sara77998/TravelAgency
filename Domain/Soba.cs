using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Broj sobe")]
        public int BrojSobe { get; set; }
        [DisplayName("Tip sobe")]
        public string TipSobe { get; set; }
        public bool Zauzeta { get; set; }
        public override string ToString()
        {
            return $"{Hotel.Naziv} {BrojSobe} {TipSobe} {Zauzeta}";
        }
    }
}
