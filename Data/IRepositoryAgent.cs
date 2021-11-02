using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepositoryAgent : IRepository<Agent>
    {
        Agent GetByUsernameAndPassword(Agent agent);
    }
}
