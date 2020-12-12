using System.Collections.Generic;

namespace CharacterCreator
{
    internal class Sql
    {
        internal class SqlCharacterDatabase : ICharacterDatabase
        {
            private string _connString;

            public SqlCharacterDatabase ( string connString )
            {
                _connString=connString;
            }

            public Character Add ( Character character )
            {
                throw new System.NotImplementedException();
            }

            public Character AddCore ( Character character )
            {
                throw new System.NotImplementedException();
            }

            public void Delete ( int id )
            {
                throw new System.NotImplementedException();
            }

            public void Delete ( object id )
            {
                throw new System.NotImplementedException();
            }

            public Character Get ( int id )
            {
                throw new System.NotImplementedException();
            }

            public IEnumerable<Character> GetAll ()
            {
                throw new System.NotImplementedException();
            }

            public void Update ( int id, Character character )
            {
                throw new System.NotImplementedException();
            }
        }
    }
}