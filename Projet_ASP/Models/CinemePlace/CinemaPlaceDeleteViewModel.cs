using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Projet_ASP.Models.CinemePlace
{
    public class CinemaPlaceDeleteViewModel
    {
        [HiddenInput]
        [Required]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom du cinema")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }

        [DisplayName("Rue")]
        public string Street { get; set; }

        [DisplayName("Numéro")]
        public string Number { get; set; }
    }
}
