using BLL_Cinema.Entities;
using DAL = DAL_Cinema.Entities;
using BLL_Cinema.Mappers;
using Shared.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL_Cinema.Services
{
    public class MovieService : IMovieRepository<Movie>
    {
        private readonly IMovieRepository<DAL.Movie> _repository;
        public MovieService(IMovieRepository<DAL.Movie> repository)
        {
            _repository = repository;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Movie> Get()
        {
            return _repository.Get().Select(d => d.ToBll());
        }

        public Movie Get(int id) 
        {
            return _repository.Get(id).ToBll();
        }

        public int Insert(Movie entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public void Update(Movie entity)
        {
            _repository.Update(entity.ToDAL());
        }
    }
}
