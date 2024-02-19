using Shared.Repositories;
using BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL_Cinema.Mappers;

namespace BLL_Cinema.Services
{
    public class CinemaPlaceService : ICinemaPlaceRepository<CinemaPlace>
    {
        private readonly ICinemaPlaceRepository<DAL.CinemaPlace> _cinemaPlaceRepository;
        private readonly ICinemaRoomRepository<DAL.CinemaRoom> _cinemaRoomRepository;
        private readonly IDiffusionRepository<DAL.Diffusion> _diffusionRepository;

        public CinemaPlaceService(ICinemaPlaceRepository<DAL.CinemaPlace> cinemaRepository, ICinemaRoomRepository<DAL.CinemaRoom> cinemaRoomRepository, IDiffusionRepository<DAL.Diffusion> diffusionRepository)
        {
            _cinemaPlaceRepository = cinemaRepository;
            _cinemaRoomRepository = cinemaRoomRepository;
            _diffusionRepository = diffusionRepository; 
        }

        public IEnumerable<CinemaPlace> Get()
        {
            return _cinemaPlaceRepository.Get().Select (d => d.ToBLL());
        }

        public CinemaPlace Get(int id)
        {
            CinemaPlace entity = _cinemaPlaceRepository.Get(id).ToBLL();
            entity.AddGroupDiffusions(_diffusionRepository.GetByCinemaPlace(id).Select(d => d.ToBll()));
            entity.AddGroupCinemaRoom(_cinemaRoomRepository.GetByCinemaRoom(id).Select(d => d.ToBLL()));
            return entity;
        }
        public int Insert(CinemaPlace entity)
        {
            return _cinemaPlaceRepository.Insert(entity.ToDAL());
        }

        public void Update(CinemaPlace entity)
        {
            _cinemaPlaceRepository.Update(entity.ToDAL());
        }

        public void Delete(int id)
        {
            _cinemaPlaceRepository.Delete(id);
        }
    }
}
