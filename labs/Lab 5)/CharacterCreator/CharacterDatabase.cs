/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 5
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator
{
    public abstract class CharacterDatabase : ICharacterDatabase
    {
      
        public Character Add ( Character character )
        {
          
            if (character == null)
                throw new ArgumentNullException(nameof(character));


            Validation.ObjectValidator.ValidateFullObject(character);
     
            var existing = GetByName(character.Name);
            if (existing != null)
                throw new InvalidOperationException("Character must be unique");

            try
            {
                return AddCore(character);
            } catch (Exception e)
            {
                
                throw new InvalidOperationException("Add Failed", e);
            };
        }

       
        public void Delete ( int id )
        {
           
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

                    
            try
            {
                DeleteCore(id);
            } catch (Exception e)
            {
               
                throw new InvalidOperationException("Delete Failed", e);
            };
        }

        public IEnumerable<Character> GetAll ()
        {
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
               
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }

       
        public Character Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            try
            {
                return GetByIdCore(id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Get Failed", e);
            };
        }

   
        public void Update ( int id, Character character )
        {
          
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character == null)
                throw new ArgumentNullException(nameof(character));


            Validation.ObjectValidator.ValidateFullObject(character);
         
           
            var existing = GetByName(character.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Character must be unique");

                       
            try
            {
                UpdateCore(id, character);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Update Failed", e);
            };
        }

        protected abstract Character AddCore ( Character character );

        protected abstract void DeleteCore ( int id );

        protected virtual Character GetByName ( string name ) => GetAll().FirstOrDefault(x => String.Compare(x.Name, name, true) == 0);

        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract Character GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Character character );

        Character ICharacterDatabase.AddCore ( Character character )
        {
            throw new NotImplementedException();
        }

        public void Delete ( object id )
        {
            throw new NotImplementedException();
        }
    }
}