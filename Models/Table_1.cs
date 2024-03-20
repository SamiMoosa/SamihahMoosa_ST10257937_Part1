using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Test.Models
{
    public class Table_1 
    {

        public static string con_string = "Server=tcp:sami-sql-server.database.windows.net,1433;Initial Catalog=sami-DB;Persist Security Info=False;User ID=samimoosa;Password=Ilovecapetown2410;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);


        public String Name { get; set; }

        public String Surname { get; set; }

        public String Email { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public int insert_User(Table_1 m)
        {

            //declaring strong with object name "sql: where we will write the insert statements
            //string sql = @"insert into Table_1([[username], [userSurname], userEmail]) value

            //SQLCommand cmd = new SQLCommand(sql, con);

            //return cmd.ExecuteNonQuery();
            //same methods below, but as you can see... much longer to complete
        
                string sql = "INSERT INTO Table_1 (UserName, userSurname, userEmail) VALUES (@Name, @Surname, @Email)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", m.Name);
                cmd.Parameters.AddWithValue("@Name", m.Surname);
                cmd.Parameters.AddWithValue("@Name", m.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
        
            }
        }
    }
