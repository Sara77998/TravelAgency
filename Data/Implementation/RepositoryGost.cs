using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryGost : IRepositoryGost
    {
        private TravelAgencyContext context;
        public RepositoryGost(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Gost s)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gost s)
        {
            throw new NotImplementedException();
        }

        public Gost FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Gost> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Gost> Search(Expression<Func<Gost, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
