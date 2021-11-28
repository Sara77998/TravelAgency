using Data.UnitOfWork;
using Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Models;



namespace TravelAgency.Validations
{
    public class ValidacijaRezervacije
    {
        internal static bool IspravanDatum(RezervacijaVM model)
        {
            if (DateTime.Compare(model.Rezervacija.DatumOd, model.Rezervacija.DatumDo) > 0 || model.Rezervacija.DatumOd < DateTime.Now || model.Rezervacija.DatumDo < DateTime.Now)
            {
                return false;
            }
            return true;
        }
        
        internal static bool IspravnaListaGostiju(RezervacijaVM model)
        {
            if (model.Rezervacija.StavkeRezervacije == null)
            {
                return false;
            }
            return true;
        }
    }
}
