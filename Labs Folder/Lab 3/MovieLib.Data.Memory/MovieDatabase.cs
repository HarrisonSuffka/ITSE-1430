using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLib;

namespace MovieLib.Data.Memory {
    /// <summary>Base class for movie database.</summary>
    public abstract class MovieDatabase : IMovieDatabase {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        public Movie Add(Movie movie)
        {
            if (movie == null)
                return null;

            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;

            return AddCore(movie);
        }

        /// <summary>Get a specific movie.</summary>
        /// <returns>The movie, if it exists.</returns>
        public Movie Get(int id)
        {
            if (id <= 0)
                return null;

            return GetCore(id);
        }

        /// <summary>Gets all movies.</summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The movie to remove.</param>
        public void Remove(int id)
        {
            if (id <= 0)
                return;

            RemoveCore(id);
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie.</returns>
        public Movie Update(Movie movie)
        {
            if (movie == null)
                return null;

            if (!ObjectValidator.TryValidate(movie, out var errors))
                return null;

            var existing = GetCore(movie.Id);
            if (existing == null)
                return null;

            return UpdateCore(existing, movie);
        }

        protected abstract Movie GetCore(int id);

        protected abstract IEnumerable<Movie> GetAllCore();

        protected abstract void RemoveCore(int id);

        protected abstract Movie UpdateCore(Movie existing, Movie newItem);

        protected abstract Movie AddCore(Movie movie);

    }
}