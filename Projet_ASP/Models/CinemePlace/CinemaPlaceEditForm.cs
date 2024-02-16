using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_ASP.Models.CinemePlace
{
    public class CinemaPlaceEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom du cinema")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        [Required(ErrorMessage = "La ville est obligatoire.")]
        [MinLength(2, ErrorMessage = "La ville doit avoir au minimum 2 caractères.")]
        public string City { get; set; }

        [DisplayName("Rue")]
        [Required(ErrorMessage = "La rue est obligatoire.")]
        [MinLength(2, ErrorMessage = "La rue doit avoir au minimum 2 caractères.")]
        public string Street { get; set; }

        [DisplayName("Numéro")]
        [Required(ErrorMessage = "Le numéro est obligatoire.")]
        [MinLength(2, ErrorMessage = "Le numéro doit avoir au minimum 2 chiffres.")]
        public string Number { get; set; }
    }
}
