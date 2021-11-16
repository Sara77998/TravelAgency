using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        //[Required]
        //[StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Password { get; set; }
    }
}
