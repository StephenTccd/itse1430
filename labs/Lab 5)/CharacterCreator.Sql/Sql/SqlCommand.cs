namespace CharacterCreator.Sql
{
    internal class SqlCommand
    {
        private string v;
        private SqlConnection connection;

        public SqlCommand ( string v, SqlConnection connection )
        {
            this.v=v;
            this.connection=connection;
        }
    }
}