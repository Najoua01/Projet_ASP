using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_ASP.Models.CinemaRoom
{
    public class CinemaRoomListItemViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; set; }

        [DisplayName("Nombre de place")]
        public int SeatsCount { get; set; }

        [DisplayName("Numéro de la salle")]
        public int Number { get; set; }
        
        [DisplayName("Largeur de l'acran")]
        public int ScreenWidth { get; set; }
        
        [DisplayName("Hauteur de l'écran")]
        public int ScreenHeight { get; set; }
        
        [DisplayName("Diffusion 3D")]
        public bool Can3D { get; set; }
        
        [DisplayName("Diffusion 4DX")]
        public bool Can4DX { get; set; }
        
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
    }
}
