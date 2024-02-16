using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_ASP.Models.CinemePlace
{
    public class CinemaPlaceCreateForm
    {
        [DisplayName("Nom du cinema")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [MinLength(2, ErrorMessage ="Le nom doit avoir au minimum 2 caractères.")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        [Required(ErrorMessage = "La ville est obligatoire.")]
        [MinLength(2, ErrorMessage = "La ville doit avoir au minimum 2 caractères.")]
        public string City { get; set; }

        [DisplayName("Rue")]
        [Required(ErrorMessage = "La rue est obligatoire.")]
        [MinLength(2, ErrorMessage = "La rue doit avoir au minimum 2 caractères.")]
        public string Street { get; set; }

        [DisplayName("Number")]
        [Required(ErrorMessage = "Le numéro est obligatoire.")]
        [MinLength(1, ErrorMessage = "Le numéro doit avoir au minimum 1 chiffre.")]
        public string Number { get; set; }
    }
}
