using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace Gallery
{
    class DatabaseHelper
    {
        public static string cs = ConfigurationManager.ConnectionStrings["ALDB"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(cs);
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        //  private static SqlDataAdapter adapter;

        public static bool SignUpFrom(User user)
        {
            string query = "INSERT INTO USER_TBL VALUES(@email,@pass,@name,null,null,null,null)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", User.Email);
            cmd.Parameters.AddWithValue("@pass", user.Password);
            cmd.Parameters.AddWithValue("@name", user.Name);

            int n = cmd.ExecuteNonQuery();
            DatabaseHelper.connection.Close();

            return n > 0 ? true : false;
        }

        public static bool LoginForm(User user)
        {
            string query = "SELECT Email,Pass from USER_TBL WHERE Email = @email and Pass = @pass";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", User.Email);
            cmd.Parameters.AddWithValue("@pass", user.Password);

            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DatabaseHelper.connection.Close();
                return true;
            }

            DatabaseHelper.connection.Close();
            return false;
        }

        public static User GetUser(string email)
        {

            string query = "SELECT * FROM USER_TBL WHERE Email = @email";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email);
            reader = cmd.ExecuteReader();
            User user = new User();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    user.Name = reader.GetValue(2).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(3)))
                    {
                        user.Gender = reader.GetValue(3).ToString();
                    }

                    if (!DBNull.Value.Equals(reader.GetValue(4)))
                    {
                        user.Location = reader.GetValue(4).ToString();
                    }

                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        user.Phone = reader.GetValue(5).ToString();
                    }



                    if (!DBNull.Value.Equals(reader.GetValue(6)))
                    {
                        user.Picture = GetPhoto((byte[])reader.GetValue(6));
                    }
                    else
                    {
                        user.Picture = Properties.Resources.user2;
                    }
                }

            }

            connection.Close();
            return user;
        }

        private static Image GetPhoto(byte[] p)

        {

            MemoryStream stream = new MemoryStream(p);

            return Image.FromStream(stream);

        }
    }
}