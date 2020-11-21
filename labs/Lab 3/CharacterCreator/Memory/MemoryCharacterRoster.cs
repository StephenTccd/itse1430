using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator.Memory
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {
        protected override Character AddCore ( Character character )
        {
            var item = CloneCharacter(character);
            item.Id = _id++;
            _character.Add(item);
            character.Id = item.Id;
            return character;

            #region Array code 
            #endregion
        }

        protected override void DeleteCore ( int id )
        {
            var character = FindById(id);
            if (character != null)
            {
                _character.Remove(character);
            };

            #region For Arrays
            #endregion
        }

        protected override IEnumerable<Character> GetAllCore ()
        {

            foreach (var character in _character)

                yield return CloneCharacter(character);


            #region Arrays
            #endregion
        }


        protected override Character GetByIdCore ( int id )
        {
            var character = FindById(id);
            return (character != null) ? CloneCharacter(character) : null;
        }


        protected override Character GetByName ( string name )
        {
            foreach (var character in _character)
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return CloneCharacter(character);
            };

            return null;
        }

        protected override void UpdateCore ( int id, Character character )
        {
            var existing = FindById(id);

            CopyCharacter(existing, character);

        }

        private Character CloneCharacter ( Character character )
        {
            var item = new Character();
            item.Id = character.Id;

            CopyCharacter(item, character);

            return item;
        }

        private void CopyCharacter ( Character target, Character source )
        {
            target.Name = source.Name;
            target.Race = source.Race;
            target.Profession = source.Profession;
            target.Strength = source.Strength;
            target.Intelligence = source.Intelligence;
            target.Agility = source.Agility;
            target.Constitution = source.Constitution;
            target.Charisma = source.Charisma;
            target.Description = source.Description;
        }

        private Character FindById ( int id )
        {
            foreach (var character in _character)
            {
                if (character?.Id == id)
                    return character;
            };

            return null;
        }

        private List<Character> _character = new List<Character>();
        private int _id = 1;
    }
}
