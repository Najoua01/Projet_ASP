using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_ASP.Models.CinemePlace
{
    public class CinemaPlaceListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Nom")]
        public string Name { get; set; }

        [DisplayName("Ville")]
        public string City { get; set; }
    }
}
