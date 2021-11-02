using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Agent
    {
        public int AgentID { get; set; }
        public int TuristickaAgencijaID { get; set; }
        public TuristickaAgencija TuristickaAgencija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
