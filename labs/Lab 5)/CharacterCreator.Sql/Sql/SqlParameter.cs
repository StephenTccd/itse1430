namespace CharacterCreator.Sql
{
    internal class SqlParameter
    {
        private string v;
        private string _name;

        public SqlParameter ( string v, string name )
        {
            this.v=v;
            this._name=name;
        }
    }
}