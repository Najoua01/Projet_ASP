using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get; private set; }
        public string Title { get; private set; }
        public string? SubTitle { get; private set; }
        public short ReleaseYear { get; private set; }
        public string Synopsis { get; private set; }
        public string PosterUrl { get; private set; }
        public int Duration { get; private set; }

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
    }
}
