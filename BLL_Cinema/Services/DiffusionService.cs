using BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_Cinema.Mappers;

namespace BLL_Cinema.Services
{
    public class DiffusionService : IDiffusionRepository<Diffusion>
    {
        private readonly IDiffusionRepository<DAL.Diffusion> _repository;
        public DiffusionService(IDiffusionRepository<DAL.Diffusion> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Diffusion> Get()
        {
            return _repository.Get().Select(d => d.ToBll());
        }

        public Diffusion Get(int id)
        {
            return _repository.Get(id).ToBll();
        }

        public int Insert(Diffusion entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Diffusion entity)
        {
            _repository.Update(entity.ToDAL());
        }
    }
}
