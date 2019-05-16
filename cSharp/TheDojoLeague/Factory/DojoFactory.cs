using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using TheDojoLeague.Models;
using Microsoft.Extensions.Options;
 
namespace TheDojoLeague.Factory
{
    public class DojoFactory
    {
        private MySqlOptions _options;
        public DojoFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(_options.ConnectionString);
            }
        }

        public IEnumerable<Dojo> FindAllDojos()
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Dojo>("SELECT * FROM dojos");
            }
        }

        public void Add(Dojo dojo)
        {
            using(IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO dojos (name, location, description, created_at, updated_at) VALUES (@Name, @Location, @Description, @Created_At, @Updated_At)";
                dbConnection.Open();
                dbConnection.Execute(query, dojo);
            }
        }

        public Dojo FindDojo(int dojo_id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var query =
                @"
                SELECT * FROM dojos WHERE dojo_id = @Id;
                SELECT * FROM ninjas WHERE dojo_id = @Id;
                ";
        
                using (var multi = dbConnection.QueryMultiple(query, new {Id = dojo_id}))
                {
                    Dojo dojo = multi.Read<Dojo>().Single();
                    dojo.Ninjas = multi.Read<Ninja>().ToList();
                    return dojo;
                }
            }
        }

        public Dojo FindOneById(int dojo_id)
        {
            using(IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var query =
                @"
                SELECT * FROM dojos WHERE dojo_id = @Id;
                ";
        
                return dbConnection.QuerySingle<Dojo>(query, new {Id = dojo_id});
            }
        }

    }
}