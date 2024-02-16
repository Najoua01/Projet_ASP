using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_ASP.Models.Movie
{
    public class MovieListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }

        [DisplayName("Titre")]
        public string Title { get; set; }

        [DisplayName("Sous_titre")]
        public string? SubTitle { get; set; }

        [DisplayName("Année de sortie")]
        public short ReleaseYear { get; set; }

        [DisplayName("Synopsis")]
        public string Synopsis { get; set; }

        [DisplayName("Durée")]
        public int Duration { get; set; }
        
        [DisplayName("Affiche")]
        public string PosterUrl { get; set; }
    }
}
