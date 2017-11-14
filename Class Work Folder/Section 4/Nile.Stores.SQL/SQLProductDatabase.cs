using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.SQL
{
    /// <summary> Provides an implantation of <see cref="IPrdoductDatabase"/> using SQL Server </summary>
    public class SQLProductDatabase : ProductDatabase
    {

        #region Construction

        public SQLProductDatabase ( string connectionString)
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
        #endregion

        protected override Product AddCore( Product product )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Product> GetAllCore()
        {
            using (var connection = OpenDatabase())
            {
                var cmd = new SqlCommand("GetAllProducts", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                var products = new List<Product>();

                using (var reader = cmd.ExecuteReader())
                {
                    while( reader.Read())
                    {
                        //reader.GetName(0);
                        //reader.GetFieldType(1);
                        //Convert.ToInt32(reader["Id"]);

                        var product = new Product() 
                        {
                            Id = reader.IsDBNull(0) ? 0 :reader.GetInt32(0),
                            Name = reader.GetFieldValue<string>(1),
                            Description = reader.GetString(3),
                            Price = reader.GetDecimal(2),
                            IsDiscontinued = reader.GetBoolean(4)
                        };
                        products.Add(product);
                    };
                };

                    return new Product[0];
            };

        }

        protected override Product GetCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override Product UpdateCore( Product existing, Product newItem )
        {
            throw new NotImplementedException();
        }

        private SqlConnection OpenDatabase()
        {
            //var conString = @"Server=(localdb)\ProjectsV13;Database=NileDatabase;Integrated Security=True;";

            var connection = new SqlConnection(_connectionString);

            connection.Open();

            return connection;
        }
    }
}
