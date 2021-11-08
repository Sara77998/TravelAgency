using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Gost
    {
        public int GostID { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9, ErrorMessage ="Mora sadrzati 9 cifara")]
        public string Pasos { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
