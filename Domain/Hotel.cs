using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Zemlja { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int BrojZvezdinca { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
