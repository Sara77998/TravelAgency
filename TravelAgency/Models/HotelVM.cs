using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    public class HotelVM
    {
        public Hotel Hotel { get; set; }
        public List<Soba> Sobe { get; set; }
    }
}
