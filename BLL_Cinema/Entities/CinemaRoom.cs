using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Cinema.Entities
{
    public class CinemaRoom
    {
        public int Id_CinemaRoom { get; private set; }
        public int SeatsCount { get; private set; }
        public int Number { get; private set; }
        public int ScreenWidth { get; private set; }
        public int ScreenHeight { get; private set; }
        public bool Can3D { get; private set; }
        public bool Can4DX { get; private set; }
        public int Id_CinemaPlace { get; private set; }
        public CinemaPlace CinemaPlace { get; private set; }

        public CinemaRoom(int id_cinemaRoom, int seatsCount, int number, int screenWidth, int screenHeight, bool can3D, bool can4DX, int id_cinemaPlace)
        {
            Id_CinemaRoom = id_cinemaRoom;
            SeatsCount = seatsCount;
            Number = number;
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            Can3D = can3D;
            Can4DX = can4DX;
            Id_CinemaPlace = id_cinemaPlace;
        }
    }
}
