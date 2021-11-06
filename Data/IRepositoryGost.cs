using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepositoryGost : IRepository<Gost>
    {
        void Update(Gost gost);
    }
}
