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
            throw new NotImplementedException();
        }

        public void Delete(Hotel s)
        {
            throw new NotImplementedException();
        }

        public Hotel FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Hotel> Search(Expression<Func<Hotel, bool>> pred)
        {
            throw new NotImplementedException();
        }
    }
}
