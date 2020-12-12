/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CharacterCreator.Validation
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidate ( this IValidatableObject source )
        {
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(source, new ValidationContext(source), results, true))
                return results;

            return Enumerable.Empty<ValidationResult>();
        }

        internal static void ValidateFullObject ( Character character )
        {
            throw new NotImplementedException();
        }
    }
}