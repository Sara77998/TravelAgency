using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Soba
    {
        public int SobaID { get; set; }
        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
        public int BrojSobe { get; set; }
        public string TipSobe { get; set; }
        public bool Zauzeta { get; set; }
    }
}
