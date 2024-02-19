using DAL_Cinema.Entities;
using System;
using System.Collections.Generic;


namespace BLL_Cinema.Entities
{
    public class CinemaPlace
    {
        private List<Diffusion> _diffusions;
        private List<CinemaRoom> _cinemaRooms;
        private List<Movie> _movies;

        public int Id_CinemaPlace { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }


        public Diffusion[] diffusions
        {
            get
            { 
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }
        public CinemaRoom[] cinemaRooms
        {
            get
            {
                return _cinemaRooms?.ToArray() ?? new CinemaRoom[0];
            }
        }
        public Movie[] movies
        {
            get
            {
                return _movies?.ToArray() ?? new Movie[0];
            }
        }

        public CinemaPlace(int id_cinemaPlace, string name, string city, string street, string number)
        {
            Id_CinemaPlace = id_cinemaPlace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }
        // Constructeur de CinemaPlace avec les listes des cinemaRoom, movie et diffusion + les prop de cinemaPlace
        public CinemaPlace(List<Diffusion> diffusions, List<CinemaRoom> cinemaRooms, List<Movie> movies, int id_CinemaPlace, string name, string city, string street, string number)
        {
            _diffusions = diffusions;
            _cinemaRooms = cinemaRooms;
            Id_CinemaPlace = id_CinemaPlace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }

        public void AddDiffusion(Diffusion diffusion) 
        {
            _diffusions ??= new List<Diffusion>();
            if(diffusion is null) throw new ArgumentNullException(nameof(diffusion));
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
        public void AddCinemaRoom(CinemaRoom cinemaRoom)
        {
            _cinemaRooms ??= new List<CinemaRoom>();
            if (cinemaRoom is null) throw new ArgumentNullException(nameof(cinemaRoom));
            // vérification de doublons
            if (_cinemaRooms.Contains(cinemaRoom)) throw new ArgumentException(nameof(cinemaRoom), $"La diffusion {cinemaRoom.Id_CinemaRoom} a déjà été ajouté dans la liste");
            _cinemaRooms.Add(cinemaRoom);
        }
        // Ajout de la méthode AddGroup pour rajouter un groupe de diffusion
        public void AddGroupCinemaRoom(IEnumerable<CinemaRoom> cinemaRooms)
        {
            if (cinemaRooms is null) throw new ArgumentException(nameof(cinemaRooms));
            foreach (CinemaRoom cinemaRoom in cinemaRooms)
            {
                AddCinemaRoom(cinemaRoom);
            }
        }
        public void AddMovie(Movie movie)
        {
            _movies ??= new List<Movie>();
            if (movie is null) throw new ArgumentNullException(nameof(movie));
            // vérification de doublons
            if (_movies.Contains(movie)) throw new ArgumentException(nameof(movie), $"La diffusion {movie.Id_Movie} a déjà été ajouté dans la liste");
            _movies.Add(movie);
        }
        // Ajout de la méthode AddGroup pour rajouter un groupe de diffusion
        public void AddGroupMovies(IEnumerable<Movie> movies)
        {
            if (movies is null) throw new ArgumentException(nameof(movies));
            foreach (Movie movie in movies)
            {
                AddMovie(movie);
            }
        }

        
    }
}
