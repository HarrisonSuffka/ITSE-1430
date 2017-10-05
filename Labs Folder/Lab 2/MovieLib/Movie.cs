/*
 * Harrison Suffka
 * ITSE 1430
 * Lab 2
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Represents A Movie.</summary>
    /// <remarks>This will represent a movie with other stuff.</remarks>
    public class Movie
    {
        /// <summary>Gets or sets the name</summary>
        /// <value> Never return null.</value>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>Gets or sets the description</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }


        /// <summary>Gets or sets the length</summary>
        public decimal Length { get; set; } = 0;

        /// <summary>Determines if owned</summary>
        public bool IsOwned { get; set; }

        public override string ToString()
        {
            return Title;
        }

        /// <summary> Validates the object </summary>
        /// <returns> The error message or null </returns>
        public virtual string Validate()
        {
            //Name cannot be empty
            if (String.IsNullOrEmpty(Title))
                return "Title cannot be empty.";

            //Length > 0
            if (Length < 0)
                return "Length must be >= 0 ";

            return null;
        }

        private string _title;
        private string _description;

    }
}
