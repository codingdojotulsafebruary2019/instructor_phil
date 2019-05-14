using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using TheDojoLeague.Models;
using Microsoft.Extensions.Options;
 
namespace TheDojoLeague.Factory
{
    public class NinjaFactory
    {
        private MySqlOptions _options;
        public NinjaFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(_options.ConnectionString);
            }
        }

        public IEnumerable<Ninja> FindAllNinjas()
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                string query = "SELECT ninjas.ninja_id, ninjas.name, ninjas.level, ninjas.description, ninjas.dojo_id, dojos.dojo_id, dojos.name, dojos.location, dojos.description FROM ninjas JOIN dojos on ninjas.dojo_id = dojos.dojo_id;";

                IEnumerable<Ninja> allNinjas = dbConnection.Query<Ninja, Dojo, Ninja>(query, (ninja, dojo) => { ninja.Dojo = dojo; return ninja; }, splitOn: "Dojo_Id");
                return allNinjas;
            }
        }

        public void Add(Ninja ninja)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO ninjas (name, level, description, dojo_id, created_at, updated_at) VALUES (@Name, @Level, @Description, @Dojo_Id, @Created_At, @Updated_At)";
                dbConnection.Open();
                dbConnection.Execute(query, ninja);
            }
        }
    }
}