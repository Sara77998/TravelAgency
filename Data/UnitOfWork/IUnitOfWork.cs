using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepositoryAgent Agent { get; set; }
        public IRepositoryGost Gost { get; set; }
        public IRepositoryHotel Hotel { get; set; }
        public IRepositoryRezervacija Rezervacija { get; set; }
        public IRepositorySoba Soba { get; set; }
        public IRepositoryTuristickaAgencija TuristickaAgencija { get; set; }
        void Commit();
    }
}
