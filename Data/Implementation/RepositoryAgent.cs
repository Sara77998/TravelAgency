using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryAgent : IRepositoryAgent
    {
        private TravelAgencyContext context;
        public RepositoryAgent(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Agent s)
        {
            throw new NotImplementedException();
        }

        public void Delete(Agent s)
        {
            throw new NotImplementedException();
        }

        public Agent FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Agent> GetAll()
        {
            return context.Agenti.ToList();
        }

        public Agent GetByUsernameAndPassword(Agent agent)
        {
            return context.Agenti.Single(a => a.Username == agent.Username && a.Password == agent.Password);
        }

        public List<Agent> Search(Expression<Func<Agent, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
