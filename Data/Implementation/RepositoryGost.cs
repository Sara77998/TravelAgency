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
            context.Add(s);
        }

        public void Delete(Gost s)
        {
            throw new NotImplementedException();
        }

        public Gost FindById(int id)
        {
            return context.Gosti.FirstOrDefault(g => g.GostID == id);
        }

        public List<Gost> GetAll()
        {
            return context.Gosti.ToList();
        }

        public List<Gost> Search(Expression<Func<Gost, bool>> pred)
        {
            return context.Gosti.Where(pred).ToList();

        }
    }
}
