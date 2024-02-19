using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Cinema.Entities
{
    public class Movie
    {
        private List<Diffusion> _diffusions;
        public int Id_Movie { get; private set; }
        public string Title { get; private set; }
        public string? SubTitle { get; private set; }
        public short ReleaseYear { get; private set; }
        public string Synopsis { get; private set; }
        public string PosterUrl { get; private set; }
        public int Duration { get; private set; }

        public Diffusion[] Diffusions
        {
            get
            { 
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }

        public Movie(int id_movie, string title, string? subTitle, short releaseYear, string synopsis, string posteUrl, int duration) 
        {
            Id_Movie = id_movie;
            Title = title;
            SubTitle = subTitle;
            ReleaseYear = releaseYear;
            Synopsis = synopsis;
            PosterUrl = posteUrl;
            Duration = duration;
        }

        public void AddDiffusion(Diffusion diffusion)
        {
            _diffusions ??= new List<Diffusion>();
            if (diffusion is null) throw new ArgumentNullException(nameof(diffusion));
            // vérification de doublons
            if (_diffusions.Contains(diffusion)) throw new ArgumentException(nameof(diffusion), $"La diffusion {diffusion.Id_Diffusion} a déjà été ajouté dans la liste");
            _diffusions.Add(diffusion);
        }
        // Ajout de la méthode AddGroup pour rajouter un groupe de diffusion
        public void AddGroupDiffusions(IEnumerable<Diffusion> diffusions)
        {
            if (diffusions is null) throw new ArgumentException(nameof(diffusions));
            foreach (Diffusion diffusion in diffusions)
            {
                AddDiffusion(diffusion);
            }
        }
    }
}
