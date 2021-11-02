using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryRezervacija : IRepositoryRezervacija
    {
        private TravelAgencyContext context;
        public RepositoryRezervacija(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Rezervacija s)
        {
            context.Add(s);
        }

        public void Delete(Rezervacija s)
        {
            throw new NotImplementedException();
        }

        public Rezervacija FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervacija> GetAll()
        {
            return context.Rezervacije.ToList();
        }

        public List<Rezervacija> Search(Expression<Func<Rezervacija, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
