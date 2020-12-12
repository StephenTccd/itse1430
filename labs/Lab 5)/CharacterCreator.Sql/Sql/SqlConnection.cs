using System;

namespace CharacterCreator.Sql
{
    internal class SqlConnection
    {
        private string _connectionString;

        public SqlConnection ( string connectionString )
        {
            _connectionString=connectionString;
        }

        internal object CreateCommand ()
        {
            throw new NotImplementedException();
        }
    }
}