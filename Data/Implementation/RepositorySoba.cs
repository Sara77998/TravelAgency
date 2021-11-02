using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositorySoba : IRepositorySoba
    {
        private TravelAgencyContext context;
        public RepositorySoba(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Soba s)
        {
            throw new NotImplementedException();
        }

        public void Delete(Soba s)
        {
            throw new NotImplementedException();
        }

        public Soba FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Soba> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Soba> Search(Expression<Func<Soba, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
