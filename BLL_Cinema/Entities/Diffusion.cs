using DAL_Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Cinema.Entities
{
    public class Diffusion
    {
        public int Id_Diffusion { get; private set; }
        public DateTime DiffusionDate { get; private set; }
        public TimeSpan DiffusionTime { get; private set; }
        public string AudioLang { get; private set; }
        public string? SubTitleLang { get; private set; }
        public int Id_CinemaRoom { get; private set; }
        public CinemaRoom CinemaRoom { get; private set; }
        public int Id_Movie { get; private set; }
        public Movie Movie { get; private set; }

        public CinemaPlace CinemaPlace { get; private set; }

        public Diffusion(int id_Diffusion, DateTime diffusionDate, TimeSpan diffusionTime, string audioLang, string? subTitleLang, int id_CinemaRoom, int id_Movie, Movie movie, CinemaPlace cinemaPlace, CinemaRoom cinemaRoom)
        {
            Id_Diffusion = id_Diffusion;
            DiffusionDate = diffusionDate;
            DiffusionTime = diffusionTime;
            AudioLang = audioLang;
            SubTitleLang = subTitleLang;
            Id_CinemaRoom = id_CinemaRoom;
            Id_Movie = id_Movie;
            this.Movie = movie;
            this.CinemaPlace = cinemaPlace;
            this.CinemaRoom = cinemaRoom;
        }

        public Diffusion(int id_Diffusion, DateTime diffusionDate, TimeSpan diffusionTime, string audioLang, string? subTitleLang, int id_CinemaRoom, int id_Movie)
        {
            Id_Diffusion = id_Diffusion;
            DiffusionDate = diffusionDate;
            DiffusionTime = diffusionTime;
            AudioLang = audioLang;
            SubTitleLang = subTitleLang;
            Id_CinemaRoom = id_CinemaRoom;
            Id_Movie = id_Movie;
        }
    }
}
