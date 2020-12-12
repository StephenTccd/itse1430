using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CharacterCreator.Sql
{
    public class SqlCharacterDatabase : CharacterDatabase
    {
        public SqlCharacterDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        public override Character AddCore ( Character character)
        {
            using (var connection = OpenConnection())
            {
              
                var command = connection.CreateCommand();
                command.CommandText = "AddCharacter";
                command.CommandType = CommandType.StoredProcedure;

                
                var parmName = new SqlParameter("@name", character.Name);
                command.Parameters.Add(parmName);

               
                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = character.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);

                
                command.Parameters.AddWithValue("@race", character.Race);
                command.Parameters.AddWithValue("@profession", character.Profession);
                command.Parameters.AddWithValue("@strength", character.Strength);
                command.Parameters.AddWithValue("@agility", character.Agility);
                command.Parameters.AddWithValue("@intelligence", character.Intelligence);
                command.Parameters.AddWithValue("@constitution", character.Constitution);
                command.Parameters.AddWithValue("@charisma", character.Charisma);


                object result = command.ExecuteScalar();
                var id = Convert.ToInt32(result);


                character.Id = id;
                return character;
            };
        }

        protected override void DeleteCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "DeleteCharacter";
                command.CommandType = CommandType.StoredProcedure;

                
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }

        protected override IEnumerable<Character> GetAllCore ()
        {
            var ds = new DataSet();

            
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetMovies", connection);
                command.CommandType = CommandType.StoredProcedure;
             
                var da = new SqlDataAdapter() {
                    SelectCommand = command
                };

                da.Fill(ds);
            };

           
            var table = ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        protected override Character GetByIdCore ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "GetCharacter";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var characterId = reader.GetInt32(0);
                        if (characterId == id)
                        {
                            return new Character() {
                                Name = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Race = reader.GetFieldValue<string>(3),
                                Profession = reader.GetFieldValue<string>(3),
                                Strength = reader.IsDBNull(4) ? 50 : reader.GetFieldValue<int>(4),
                                Intelligence = reader.IsDBNull(4) ? 50 : reader.GetFieldValue<int>(4),
                                Agility = reader.IsDBNull(4) ? 50 : reader.GetFieldValue<int>(4),
                                Constitution = reader.IsDBNull(4) ? 50 : reader.GetFieldValue<int>(4),
                                Charisma = reader.IsDBNull(4) ? 50 : reader.GetFieldValue<int>(4),
                            };
                        };
                    };
                };
            };

            return null;
        }

        protected override Character GetByName ( string name )
        {
            var character = GetAllCore();

            return character.FirstOrDefault(character => String.Compare(character.Name, name, true) == 0);
        }

        protected override void UpdateCore ( int id, Character character )
        {
            var sqlConnection = OpenConnection();
            using (var connection = sqlConnection)
            {
               
                var command = connection.CreateCommand();
                command.CommandText = "UpdateCharacter";
                command.CommandType = CommandType.StoredProcedure;

                var parmName = new SqlParameter("@name", character.Name);
                command.Parameters.Add(parmName);

                var parmDescription = command.CreateParameter();
                parmDescription.ParameterName = "@description";
                parmDescription.Value = character.Description;
                parmDescription.SqlDbType = SqlDbType.NVarChar;
                command.Parameters.Add(parmDescription);
                command.Parameters.AddWithValue("@race", character.Race);
                command.Parameters.AddWithValue("@profession", character.Profession);
                command.Parameters.AddWithValue("@strength", character.Strength);
                command.Parameters.AddWithValue("@intelligence", character.Intelligence);
                command.Parameters.AddWithValue("@agility", character.Agility);
                command.Parameters.AddWithValue("@constitution", character.Constitution);
                command.Parameters.AddWithValue("@charisma", character.Charisma);
                command.ExecuteNonQuery();
            };
        }

        private SqlConnection OpenConnection ()
        {
            
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public override Character AddCore ( Character character )
        {
            throw new NotImplementedException();
        }

        protected override void UpdateCore ( int id, Character character ) => throw new NotImplementedException();
    }

}