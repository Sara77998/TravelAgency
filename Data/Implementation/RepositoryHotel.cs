using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class RepositoryHotel : IRepositoryHotel
    {
        private TravelAgencyContext context;
        public RepositoryHotel(TravelAgencyContext context)
        {
            this.context = context;
        }
        public void Add(Hotel s)
        {
            context.Add(s);
        }

        public void Delete(Hotel s)
        {
            context.Remove(s);
        }

        public Hotel FindById(int id)
        {
            return context.Hoteli.FirstOrDefault(h => h.HotelID == id);
        }

        public List<Hotel> GetAll()
        {
            return context.Hoteli.ToList();
        }

        public List<Hotel> Search(Expression<Func<Hotel, bool>> pred)
        {
            return context.Hoteli.Where(pred).ToList();
        }
    }
}
