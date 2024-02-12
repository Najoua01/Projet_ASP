using System;
using System.Collections.Generic;
using System.Text;
using BLL = BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;

namespace BLL_Cinema.Mappers
{
    internal static class Mapper
    {
        public static BLL.CinemaPlace ToBLL(this DAL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaPlace(
                entity.Id_CinemaPlace,
                entity.Name,
                entity.City,
                entity.Street,
                entity.Number);
        }

        public static DAL.CinemaPlace ToDAL(this BLL.CinemaPlace entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaPlace()
            {
                Id_CinemaPlace = entity.Id_CinemaPlace,
                Name = entity.Name,
                City = entity.City,
                Street = entity.Street,
                Number = entity.Number
            };
        }
        public static BLL.CinemaRoom ToBLL(this DAL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new BLL.CinemaRoom(
                entity.Id_CinemaRoom,
                entity.SeatsCount,
                entity.Number,
                entity.ScreenWidth,
                entity.ScreenHeight,
                entity.Can3D,
                entity.Can4DX,
                entity.Id_CinemaPlace);
        }

        public static DAL.CinemaRoom ToDAL(this BLL.CinemaRoom entity)
        {
            if (entity is null) return null;
            return new DAL.CinemaRoom()
            {
                Id_CinemaRoom = entity.Id_CinemaRoom,
                SeatsCount = entity.SeatsCount,
                Number = entity.Number,
                ScreenWidth = entity.ScreenWidth,
                ScreenHeight = entity.ScreenHeight,
                Can3D = entity.Can3D,
                Can4DX = entity.Can4DX,
                Id_CinemaPlace = entity.Id_CinemaPlace
            };
        }
    }
}
