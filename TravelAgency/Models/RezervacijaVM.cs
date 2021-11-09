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
    }
}
