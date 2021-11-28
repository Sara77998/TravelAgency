using Domain;
using Microsoft.EntityFrameworkCore;
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
            context.Add(s);
        }

        public void Delete(Soba s)
        {
            context.Remove(s);
        }

        public Soba FindById(int id)
        {
            //mora da se includuje i hotel
            return context.Sobe.Include(s => s.Hotel).Single(s => s.SobaID == id);
        }

        public List<Soba> GetAll()
        {
            return context.Sobe.Include(s => s.Hotel).ToList();
        }

        public List<Soba> Search(Expression<Func<Soba, bool>> pred)
        {
            return context.Sobe.Include(s => s.Hotel).Where(pred).ToList();
        }
    }
}
