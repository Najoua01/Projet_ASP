using BLL_Cinema.Entities;
using Projet_ASP.Controllers;
using Projet_ASP.Models.CinemaRoom;
using Projet_ASP.Models.CinemePlace;
using Projet_ASP.Models.Diffusion;
using Projet_ASP.Models.Movie;

namespace Projet_ASP.Handlers
{
    public static class Mapper
    {
        #region CinemaPlace
        public static CinemaPlaceListItemViewModel ToListItem(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceListItemViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City
            };
        }
        public static CinemaPlaceDetailsViewModel ToDetails(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDetailsViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number,
                Diffusions = entity.diffusions.Select(d => d.ToListItem()),
                CinemaRooms = entity.cinemaRooms.Select(d => d.ToListItem())
            };
        }
        public static CinemaPlace ToBLL(this CinemaPlaceCreateForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                0,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number
            );
        }
        public static CinemaPlaceEditForm Edit(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceEditForm()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }
        public static CinemaPlace EditToBLL(this CinemaPlaceEditForm entity)
        {
            if (entity is null) return null;
            return new CinemaPlace(
                entity.Id_CinemaPlace,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number
            );
        }
        public static CinemaPlaceDeleteViewModel Delete(this CinemaPlace entity)
        {
            if (entity is null) return null;
            return new CinemaPlaceDeleteViewModel()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }
        #endregion

        #region CinemaRoom
        public static CinemaRoomListItemViewModel ToListItem(this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomListItemViewModel()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX
            };
        }
        public static CinemaRoomDetailsViewModel ToDetails(this CinemaRoom entity)
        {
            if (entity is null) return null;
            return new CinemaRoomDetailsViewModel()
            {
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX
            };
        }
        #endregion

        #region Movie
        public static MovieListItemViewModel ToListItem(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieListItemViewModel()
            {
                Id_Movie = entity.Id_Movie,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }
        public static MovieDetailsViewModel ToDetails(this Movie entity)
        {
            if (entity is null) return null;
            return new MovieDetailsViewModel()
            {
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                ReleaseYear = entity.ReleaseYear,
                Synopsis = entity.Synopsis,
                PosterUrl = entity.PosterUrl,
                Duration = entity.Duration
            };
        }
        #endregion

        #region Diffusion
        public static DiffusionListItemViewModel ToListItem(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionListItemViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                AudioLang = entity.AudioLang,
                SubTitleLang = entity.SubTitleLang,
                Can3D = entity.CinemaRoom?.Can3D ?? false,
                Can4DX = entity.CinemaRoom?.Can4DX ?? false,
                Title = entity.Movie.Title,
                ReleaseYear = entity.Movie.ReleaseYear,
                Duration = entity.Movie.Duration,
                NameCinemaPlace = entity.CinemaPlace.Name,
                NumberCinemaRoom = entity.CinemaRoom.Number
            };
        }
        public static DiffusionDetailsViewModel ToDetails(this Diffusion entity)
        {
            if (entity is null) return null;
            return new DiffusionDetailsViewModel()
            {
                Id_Diffusion = entity.Id_Diffusion,
                DiffusionDate = entity.DiffusionDate,
                DiffusionTime = entity.DiffusionTime,
                AudioLang = entity.AudioLang,
                SubTitleLang = entity.SubTitleLang,
                Can3D = entity.CinemaRoom.Can3D,
                Can4DX = entity.CinemaRoom.Can4DX,
                Title = entity.Movie.Title,
                ReleaseYear = entity.Movie.ReleaseYear,
                Duration = entity.Movie.Duration,
                NameCinemaPlace = entity.CinemaPlace.Name,
                NumberCinemaRoom= entity.CinemaRoom.Number
            };
        }
        #endregion
    }
}