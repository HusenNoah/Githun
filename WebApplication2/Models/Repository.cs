using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.ViewModels;

namespace WebApplication2.Models
{
    public class Repository
    {
        public string dbconn = "Data source=.; Initial Catalog=Core; Integrated Security=SSPI";

        internal void CreatePerson(Persons persons)
        {
            using (var conn = new SqlConnection(dbconn))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Persons VALUES(@name,@addres,@phone)";
                cmd.Parameters.AddWithValue("@name", persons.Name);
                cmd.Parameters.AddWithValue("@addres", persons.Addres);
                cmd.Parameters.AddWithValue("@phone", persons.Phone);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
