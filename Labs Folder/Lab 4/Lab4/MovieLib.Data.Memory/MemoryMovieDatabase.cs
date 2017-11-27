﻿/* Harrison Suffka
 * ITSE 1430
 * Lab 4
 * 11/19/2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLib;

namespace MovieLib.Stores
{
    /// <summary>Base class for movie database.</summary>
    public class MemoryMovieDatabase : MovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected override Movie AddCore( Movie movie )
        {
            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            if (newMovie.Id <= 0)
                newMovie.Id = _nextId++;
            else if (newMovie.Id >= _nextId)
                _nextId = newMovie.Id + 1;

            return CopyMovie(newMovie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        protected override Movie GetCore( int id )
        {
            var movie = FindMovie(id);

            return (movie != null) ? CopyMovie(movie) : null;
        }

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies.</returns>
        protected override IEnumerable<Movie> GetAllCore()
        {
            foreach (var movie in _movies)
                yield return CopyMovie(movie);
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="movie">The movie to remove.</param>
        protected override void RemoveCore( int id )
        {
            var movie = FindMovie(id);

            if (movie != null)
                _movies.Remove(movie);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        protected override Movie UpdateCore( Movie existing, Movie movie )
        {
            //Find and remove existing movie
            existing = FindMovie(movie.Id);
            _movies.Remove(existing);

            //Add a copy of the new movie
            var newMovie = CopyMovie(movie);
            _movies.Add(newMovie);

            return CopyMovie(newMovie);
        }

        //Copies one movie to another
        private Movie CopyMovie( Movie movie )
        {
            if (movie == null)
                return null;

            var newMovie = new Movie();
            newMovie.Id = movie.Id;
            newMovie.Title = movie.Title;
            newMovie.Description = movie.Description;
            newMovie.Length = movie.Length;
            newMovie.isOwned = movie.isOwned;

            return newMovie;
        }

        //Find a movie by ID
        private Movie FindMovie( int id )
        {
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            };

            return null;
        }

        private List<Movie> _movies = new List<Movie>();
        private int _nextId = 1;
    }
}