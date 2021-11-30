using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryKalendar : IRepositoryKalendar
    {
        private TravelAgencyContext context;
        public RepositoryKalendar(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Kalendar s)
        {
            context.Add(s);
        }

        public void Delete(Kalendar s)
        {
            throw new NotImplementedException();
        }

        public Kalendar FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kalendar> GetAll()
        {
            return context.Kalendar.ToList();
        }

        public List<Kalendar> Search(Expression<Func<Kalendar, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
