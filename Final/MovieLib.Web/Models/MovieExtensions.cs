﻿/*
 * ITSE 1430
 * Harrison Suffka
 * 12/13/17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLib.Web.Models
{
    /// <summary>Provides extension methods for <see cref="Movie"/> and <see cref="MovieViewModel"/>.</summary>
    public static class MovieExtensions
    {
        /// <summary>Converts a <see cref="Movie"/> to a view model.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The view model.</returns>
        public static IEnumerable<MovieViewModel> ToViewModel ( this IEnumerable<Movie> source )
        {
            foreach (var item in source)
                yield return item.ToViewModel();
        }

        /// <summary>Converts a <see cref="Movie"/> to a view model.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The view model.</returns>
        public static MovieViewModel ToViewModel( this Movie source ) => new MovieViewModel() 
        {
            Id = source.Id,
            Title = source.Title,
            //CR Harrison S - (Bug) Movie rating is not being persisted
            Rating = source.Rating,
            Description = source.Description,
            Length = source.Length,
            IsOwned = source.IsOwned,
            ReleaseYear = source.ReleaseYear
        };

        /// <summary>Converts a view model to a <see cref="Movie"/>.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The movie.</returns>
        public static Movie ToMovie( this MovieViewModel source ) => new Movie() 
        {
            Id = source.Id,
            Title = source.Title,
            //CR Harrison S - (Bug) Movie rating is not being persisted
            Rating = source.Rating,
            Description = source.Description,
            Length = source.Length,
            IsOwned = source.IsOwned,
            ReleaseYear = source.ReleaseYear
        };
    }
}