using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using DeltaxIMDB.Models;

namespace DeltaxIMDB.DAL.Repository
{
    public class MovieRepository : IMovieRepository
    {
        //********************Declaration********************
        private MovieContext _MovieContext;

        //Constructor
        public MovieRepository(MovieContext Moviecontext)
        {
            _MovieContext = Moviecontext;
        }

        //********************Implementation********************


        //Display
        public IEnumerable<MovieModel> GetMovie()
        {
            return _MovieContext.Movie.ToList();
        }

        //Detail
        public MovieModel GetMovieById(int? MovieId)
        {
            return _MovieContext.Movie.Find(MovieId);
        }

        //Insert
        public void AddMovie(MovieModel Movie)
        {
            _MovieContext.Movie.Add(Movie);
        }

        //Update
        public void UpdateMovie(MovieModel Movie)
        {
            _MovieContext.Entry(Movie).State = EntityState.Modified;
        }

        //Delete
        public void DeleteMovie(int MovieId)
        {
            MovieModel Movie = _MovieContext.Movie.Find(MovieId);
            _MovieContext.Movie.Remove(Movie);
        }

        //Save
        public void save()
        {
            _MovieContext.SaveChanges();
        }


        //Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _MovieContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}