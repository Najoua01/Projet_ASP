using BLL_Cinema.Entities;
using Projet_ASP.Models.CinemePlace;

namespace Projet_ASP.Handlers
{
    public static class Mapper
    {
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
                Number = entity.Number
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
    }
}