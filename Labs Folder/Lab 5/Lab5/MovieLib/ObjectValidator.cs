/*
 * Harrison Suffka
 * ITSE 1430
 * 12-8-2017
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLib
{
    /// <summary>Validate objects</summary>
    /// <param name="value">The value to validate</param>
    /// param name="errors">The list of errors</param>
    /// <returns>True for successful validation, false otherwise</returns>
    public class ObjectValidator
    {
        public static bool TryValidate( IValidatableObject value, out IEnumerable<ValidationResult> errors )
        {
            var context = new ValidationContext(value);
            var results = new List<ValidationResult>();

            errors = results;
            return Validator.TryValidateObject(value, context, results);
        }

        /// <summary>Validates an object</summary>
        /// <param name="value">The object to validate</param>
        /// <exception cref="ValidationException"><paramref name="value"/>is invalid</exception>
        public static void Validate( IValidatableObject value )
        {
            Validator.ValidateObject(value, new ValidationContext(value));
        }
    }
}