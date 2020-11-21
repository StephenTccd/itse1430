using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator
{
    public abstract class CharacterDatabase : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            if (character == null)
                throw new ArgumentException(nameof(character));
            var existing = GetByName(character.Name) ?? throw new InvalidOperationException("Character must be unique");
            return AddCore(character);
        }
        public void Delete (int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");


            DeleteCore(id);
        }
        public IEnumerable<Character> GetAll()
        {
            return GetAllCore();
        }
        public Character Get (int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");

            return GetByIdCore(id);
        }
       
        public void Update(int id, Character character)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character == null)
                throw new ArgumentNullException(nameof(character));


            

            var existing = GetByName(character.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Character must be unique");

            UpdateCore(id, character);
        }

        protected abstract Character AddCore ( Character character );
        protected abstract void DeleteCore ( int id );
        protected virtual Character GetByName ( string name )
        {
            foreach (var character in GetAll())
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return character;
            };

            return null;
        }
        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract Character GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Character character );
        public Character Add ( Character character, out string error )
        {
            throw new NotImplementedException();
        }

        string ICharacterRoster.Update ( int id, Character character )
        {
            throw new NotImplementedException();
        }

        Character ICharacterRoster.AddCore ( Character character )
        {
            throw new NotImplementedException();
        }
    }


}
