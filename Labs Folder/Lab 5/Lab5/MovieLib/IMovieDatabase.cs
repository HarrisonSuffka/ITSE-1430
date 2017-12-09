/*
 * Harrison Suffka
 * ITSE 1430
 * 12-8-2017
 */

using System.Collections.Generic;

namespace MovieLib
{
    /// <summary>Provides a database of Movie items.</summary>
    public interface IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        Movie Add( Movie movie );

        /// <summary>Get a specific movie.</summary>
        /// <param name="id">the ID of the movie.</param>
        /// <returns>The movie if it exists.</returns>
        Movie Get( int id );

        /// <summary>Gets all of the products.</summary>
        /// <returns>The movies</returns>
        IEnumerable<Movie> GetAll();

        /// <summary>Removes the movie.</summary>
        /// <param name="id">The id of the movie to remove.</param>
        void Remove( int id );

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to update.</param>
        /// <returns>The updated movie</returns>
        Movie Update( Movie movie );
    }
}