﻿/* Harrison Suffka
 * ITSE 1430
 * Lab 4
 * 11/19/2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib 
{
    /// <summary>Validate objects.</summary>
    public static class ObjectValidator {
        /// <summary>Tries to validate an object.</summary>
        /// <param name="value">The value to validate.</param>
        /// <param name="errors">The list of errors.</param>
        /// <returns>true if validation succeeded or false otherwise.</returns>
        public static bool TryValidate(IValidatableObject value, out IEnumerable<ValidationResult> errors)
        {
            var context = new ValidationContext(value);
            var results = new List<ValidationResult>();

            errors = results;
            return Validator.TryValidateObject(value, context, results);
        }

        /// <summary>Validates an object.</summary>
        /// <param name="value">The object to validate.</param>
        /// <exception cref="ValidationException"><paramref name="value"/> is invalid.</exception>
        public static void Validate(IValidatableObject value)
        {
            Validator.ValidateObject(value, new ValidationContext(value));
        }
    }
}
