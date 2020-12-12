/*
 * Stephen Nuguid
 * ITSE 1430
 * Lab 5
 */
using System;
using System.Collections.Generic;

namespace CharacterCreator
{
    public interface ICharacterDatabase
    {
        Character Add ( Character character );
        Character AddCore ( Character character );
        void Delete ( int id );

        Character Get ( int id );

        IEnumerable<Character> GetAll ();
        void Update ( int id, Character character );
        void Delete ( object id );
    }
}
