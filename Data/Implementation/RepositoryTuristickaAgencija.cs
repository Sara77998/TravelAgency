using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryTuristickaAgencija : IRepositoryTuristickaAgencija
    {
        private TravelAgencyContext context;
        public RepositoryTuristickaAgencija(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(TuristickaAgencija s)
        {
            throw new NotImplementedException();
        }

        public void Delete(TuristickaAgencija s)
        {
            throw new NotImplementedException();
        }

        public TuristickaAgencija FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TuristickaAgencija> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TuristickaAgencija> Search(Expression<Func<TuristickaAgencija, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
