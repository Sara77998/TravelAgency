using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hotel
    {
        public int HotelID { get; set; }
        [Required]
        public string Zemlja { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        [DisplayName("Broj zvezdica")]
        [Range(1, 5,
        ErrorMessage = "Broj zvezdica mora imati vrednost od 1 do 5")]
        public int BrojZvezdinca { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        
        public string Telefon { get; set; }
        public override string ToString()
        {
            return $"{Naziv} {Zemlja} {Adresa} {BrojZvezdinca} {Email} {Telefon}";
        }
    }
}
