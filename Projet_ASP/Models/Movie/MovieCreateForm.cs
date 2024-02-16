using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_ASP.Models.Movie
{
    public class MovieCreateForm
    {
        [DisplayName("Titre")]
        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Le nom doit être compris entre 2 et 64 caractères.")]
        public string Title { get; set; }

        [DisplayName("Sous-titre")]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Le nom doit être compris entre 2 et 64 caractères.")]
        public string? SubTitle { get; set; }
        
        [DisplayName("Année de sortie")]
        [Required(ErrorMessage = "L'année de sortie est obligatoire.")]
        public short ReleaseYear { get; set; }

        [DisplayName("Synopsis")]
        [Required(ErrorMessage = "La synopsis est obligatoire.")]
        [DataType(DataType.MultilineText)]
        public string Synopsis { get; set; }

        [DisplayName("Durée")]
        [Required(ErrorMessage = "La durée est obligatoire.")]
        public int Duration { get; set; }
        [DisplayName("Affiche")]
        [Required(ErrorMessage = "L'affiche est obligatoire.")]
        public string PosterUrl { get; set; }
    }
}
