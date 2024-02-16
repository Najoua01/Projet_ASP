using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_ASP.Models.Diffusion
{
    public class DiffusionDetailsViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }

        [DisplayName("Date de diffusion")]
        [DataType(DataType.Date)]
        public DateTime DiffusionDate { get; set; }

        [DisplayName("Heure de diffusion")]
        [DataType(DataType.Time)]
        public TimeSpan DiffusionTime { get; set; }

        [DisplayName("Langue audio")]
        public string AudioLang { get; set; }

        [DisplayName("Langue des sous-titres")]
        public string? SubTitleLang { get; set; }

        [DisplayName("Projection 3D")]
        public bool Can3D { get; set; }

        [DisplayName("Projection 4DX")]
        public bool Can4DX { get; set; }

        [DisplayName("Titre du film")]
        public string Title { get; set; }

        [DisplayName("Année de sortie")]
        public short ReleaseYear { get; set; }

        [DisplayName("Durée")]
        public int Duration { get; set; }

        [DisplayName("Nom du cinéma")]
        public string NameCinemaPlace { get; set; }

        [DisplayName("Numéro de la salle")]
        public int NumberCinemaRoom { get; set; }
    }
}
