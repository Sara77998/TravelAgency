using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class RezervacijaVM
    {
        public Rezervacija Rezervacija { get; set; }
        public List<SelectListItem> Gosti { get; set; }
        public List<Gost> SviGosti { get; set; }
        public Gost Gost { get; set; }
        public int HotelID { get; set; }
        public int SobaID { get; set; }
    }
}
