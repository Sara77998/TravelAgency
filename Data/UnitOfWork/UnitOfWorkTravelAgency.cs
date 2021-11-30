using Data.Implementation;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public class UnitOfWorkTravelAgency : IUnitOfWork
    {
        private TravelAgencyContext context;
        public UnitOfWorkTravelAgency(TravelAgencyContext context)
        {
            this.context = context;
            Agent = new RepositoryAgent(context);
            Gost = new RepositoryGost(context);
            Hotel = new RepositoryHotel(context);
            Rezervacija = new RepositoryRezervacija(context);
            Soba = new RepositorySoba(context);
            TuristickaAgencija = new RepositoryTuristickaAgencija(context);

            Kalendar = new RepositoryKalendar(context);
        }
        public IRepositoryAgent Agent { get; set; }
        public IRepositoryGost Gost { get; set; }
        public IRepositoryHotel Hotel { get; set; }
        public IRepositoryRezervacija Rezervacija { get; set; }
        public IRepositorySoba Soba { get; set; }
        public IRepositoryTuristickaAgencija TuristickaAgencija { get; set; }

        public IRepositoryKalendar Kalendar { get; set; }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
