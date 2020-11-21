﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLibrary
{
    //Interfaces appear on the same line as base types but ARE NOT base types
    //MovieDatabase implements IMovieDatabase
    // A type can implement any # of interfaces
    // All members on an interface must be public and implemented

    //Abstract class required if any member is abstract
    //  1. Cannot be instantiated
    //  2. Must derive from it
    //  3. Must implement all abstract members

    /// <summary>Provides a base implementation of <see cref="IMovieDatabase"/>.</summary>
    public abstract class MovieDatabase : IMovieDatabase //, IEditableDatabase, IReadableDatabase
    {
        //Not on interface
        //public void Foo () { }

        /// <inheritdoc />
        public Movie Add ( Movie movie )
        {
            // Exception type is the base type of all exceptions
            // Arguments should always fail with Argument exceptions
            // Exception -> generic exceptions with a message
            //   ArgumentException -> generic argument exception
            //     ArgumentNullException -> argument is null and it shouldn't be
            //     ArgumentOutOfRangeException -> argument is outside excepted range (generally numeric)
            //   ValidationException -> IValidatableObject fails
            //   InvalidOperationException -> The operation is not currently valid but may be in the future
            //   SystemException -> Only generated by runtime
            //     NullReferenceException -> null is on left side of member access (null.???)
            //     StackOverflowException -> Stack overflowed
            //     OutOfMemoryException -> Out of memory 

            // Throw an exception using throw expression
            //    throw-expression ::= throw E
            //               E must be Exception 
            // Movie is not null
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));   //Argument is null and it shouldn't be, pretty much all reference types

            //Movie is valid
            ObjectValidator.ValidateFullObject(movie);
            //var results = new ObjectValidator().TryValidateFullObject(movie);
            //if (results.Count() > 0)
            //{
            //    foreach (var result in results)
            //    {
            //        error = result.ErrorMessage;
            //        return null;
            //    };
            //};

            // Movie name is unique
            //var existing = GetByName(movie.Name);
            //if (existing != null)
            //    throw new InvalidOperationException("Movie must be unique");

            // Throw expression ::= E ?? throw E
            var existing = GetByName(movie.Name);
            if (existing != null)
                throw new InvalidOperationException("Movie must be unique");
            //{
            //    error = "Movie must be unique";
            //    return null;
            //};

            // Generalize errors
            try
            {
                return AddCore(movie);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Add Failed", e);
            };
        }

        /// <inheritdoc />
        public void Delete ( int id )
        {
            // Validate Id > 0
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            //Generalize errors            
            try
            {
                DeleteCore(id);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Delete Failed", e);
            };
        }

        //Use IEnumerable<T> for readonly lists of items
        //public Movie[] GetAll ()

        /// <inheritdoc />
        public IEnumerable<Movie> GetAll ()
        {
            //object value = null;            
            //value.ToString();

            // Generalize errors
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }

        /// <inheritdoc />
        public Movie Get ( int id )
        {
            // id > 0
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            //Generalize errors
            try
            {
                return GetByIdCore(id);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Get Failed", e);
            };
        }

        /// <inheritdoc />
        public void Update ( int id, Movie movie )
        {
            //Validation
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            //Movie is valid
            //var v = new ObjectValidator();            
            ObjectValidator.ValidateFullObject(movie);
            //var results = new ObjectValidator().TryValidateFullObject(movie);
            //if (results.Count() > 0)
            //{
            //    foreach (var result in results)
            //    {
            //        return result.ErrorMessage;
            //    };
            //};

            // Movie name is unique
            var existing = GetByName(movie.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Movie must be unique");

            // Generalize errors            
            try
            {
                UpdateCore(id, movie);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Update Failed", e);
            };
        }

        /// <summary>Adds a movie to the database.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie.</returns>
        protected abstract Movie AddCore ( Movie movie );

        protected abstract void DeleteCore ( int id );

        /// <summary>Finds a movie by name.</summary>
        /// <param name="name">The movie to find.</param>
        /// <returns>The movie, if found.</returns>
        /// <remarks>
        /// The default implementation enumerates all the movies looking for a match.
        /// </remarks>
        // Expression body method => E;
        protected virtual Movie GetByName ( string name ) => GetAll().FirstOrDefault(x => String.Compare(x.Name, name, true) == 0);

        //protected virtual Movie GetByName ( string name )
        //{
        //    return GetAll().FirstOrDefault(x => String.Compare(x.Name, name, true) == 0);
        //    //foreach (var movie in GetAll())
        //    //{
        //    //    if (String.Compare(movie.Name, name, true) == 0)
        //    //        return movie;
        //    //};

        //    //return null;
        //}

        protected abstract IEnumerable<Movie> GetAllCore ();

        protected abstract Movie GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Movie movie );
    }

    // LINQ - Language Integrated Natural Query
    //   Deferred execution - Next element is not retrieved until needed
    //      Directory.GetFiles() -> string[] (not)
    //      Directory.EnumerateFiles() -> IEnumerable<string>  (deferred)
    //
    // Common extension methods for IEnumerable<T>
    //   Conversion (enumerates all the members when called)
    //     ToArray() -> T[]
    //     ToList() -> List<T>
    //   Casting (deferred execution)
    //     OfType<T>() -> Returns IEnumerable<T> of any items that are compatible with T
    //     Cast<T>() -> Returns IEnumerable<T> but crashes if anything doesn't match type
    //   Get item (not deferred) -> T
    //     First/FirstOrDefault - Gets first item (if any)
    //     Last/LastOrDefault - Gets last item (if any)
    //     Single/SingleOrDefault - Gets only item (if any)
    //  Query -> IEnumerable<T> (replaces foreach)
    //     Where(Func<T, bool>) -> IEnumerable<T>
    //     OrderBy(Func<T, member>) -> IEnumerable<T> ordered by member
    //     Select<K>(Func<T, K>) -> IEnumerable<T> 
    //     GroupBy() -> grouped IEnumerable<T>
    //     Join() -> IEnumerable<?>

    // Delegate (function object, functor)
    //   Treat a function as data 
    //  Action => void fx ()
    //  Action<T> => void fx ( T )
    //  Action<T1, T2> => void fx ( T1, T2 )
    //  Func<T> => T fx ()
    //  Func<T, R> => R fx (T)
    //  Func<T1, T2, R> => R fx (T1, T2)
    //  
    // Lambda expression / anonymous methods
    //    Method that has no name
    //    parameters => expression
    //    parameters => { statements* }
    //    parameter types are inferred, cannot use ref or out
    //    If you need more than 1 parameter or no parameters use empty parens
    // 
    // Expression bodies (limited to methods, constructors, operators, properties)
    //    method => E;
    //    T property { get => E; set => S; }
    //    T prooperty => E;
    //    Replaces a method body that has a single return statement (compiler rewrites to regular method)   

    // LINQ syntax
    //     from x in IEnumerable<T> 
    //     [where lambda expression]
    //     [orderby member, member]
    //     select E
}