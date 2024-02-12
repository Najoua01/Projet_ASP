using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_ASP.Models.CinemePlace
{
    public class CinemaPlaceDetailsViewModel
    {
        [ScaffoldColumn(false)]
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
