using DeltaxIMDB.Models;
using System;
using System.Collections.Generic;

namespace DeltaxIMDB.DAL.Interface
{
    public interface IMovieRepository :  IDisposable
    {
        IEnumerable<MovieModel> GetMovie();
        MovieModel GetMovieById(int? MovieId);
        void AddMovie(MovieModel Movie);
        void UpdateMovie(MovieModel Movie);
        void DeleteMovie(int MovieId);
        void save();
    }
}