using System;
using System.Data;

namespace CharacterCreator.Sql
{
    internal class SqlDataAdapter
    {
        public SqlDataAdapter ()
        {
        }

        public SqlCommand SelectCommand { get; set; }

        internal void Fill ( DataSet ds )
        {
            throw new NotImplementedException();
        }
    }
}