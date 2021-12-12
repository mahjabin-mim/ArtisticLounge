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

            int n = 0;

            try
            {
                 n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
            connection.Close();

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
                connection.Close();
                return true;
            }

            connection.Close();
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
                    else
                    {
                        user.Gender = "N/A";
                    }

                    if (!DBNull.Value.Equals(reader.GetValue(4)))
                    {
                        user.Location = reader.GetValue(4).ToString();
                    }
                    else
                    {
                        user.Location = "N/A";
                    }

                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        user.Phone = reader.GetValue(5).ToString();
                    }
                    else
                    {
                        user.Phone = "N/A";
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

        public static bool UpdateUser(User user)
        {
            User usr = user;
            string query = "UPDATE USER_TBL SET Name = @name, Gender = @gender, Location = @loc, Phone = @phone, Picture = @pic WHERE Email = @email";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", User.Email);
            cmd.Parameters.AddWithValue("@name", usr.Name);
            cmd.Parameters.AddWithValue("@gender", usr.Gender);
            cmd.Parameters.AddWithValue("@loc", usr.Location);
            cmd.Parameters.AddWithValue("@phone", usr.Phone);
          //  cmd.Parameters.AddWithValue("@pass", usr.Password);
            cmd.Parameters.AddWithValue("@pic", GetRawPhoto(usr.Picture));
            
            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
               connection.Close();

            return n > 0 ? true : false;
        }

        public static bool PostArt(Art art)
        {
            string query = "INSERT INTO ART_TBL VALUES (next value for ART_SQ,@name,@catagory,@price,@seller,null,@status,@img)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", art.Name);
            cmd.Parameters.AddWithValue("@catagory", art.Catagory);
            cmd.Parameters.AddWithValue("@price", art.Price);
            cmd.Parameters.AddWithValue("@seller", art.Seller);
            cmd.Parameters.AddWithValue("@status", art.Status);
            cmd.Parameters.AddWithValue("@img", GetRawPhoto(art.Art_image));

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
            connection.Close();

            return n > 0 ? true : false;

          
                
        }

        public static List<Art> GetArt()
        {
            List<Art> artList = new List<Art>();
            string[] st = {"Available","Sold"};
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @avl or Art_status = @sld";
            cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@avl", st[0]);
            cmd.Parameters.AddWithValue("@sld", st[1]);

            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    Art art = new Art();
                    art.Product_code = reader.GetValue(0).ToString();
                    art.Name = reader.GetValue(1).ToString();
                    art.Catagory = reader.GetValue(2).ToString();
                    art.Price = reader.GetValue(3).ToString();
                    art.Seller = reader.GetValue(4).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        art.Buyer = reader.GetValue(5).ToString();
                    }
                    art.Status = reader.GetValue(6).ToString();
                    art.Art_image = GetPhoto((byte[])reader.GetValue(7));

                    artList.Add(art);
                }
            }

            connection.Close();
            return artList;
        }

        public static List<Art> GetStockArt()
        {
            
            List<Art> artList = new List<Art>();
            string avl = "Available";
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @avl and Seller = @seller";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@avl", avl);
            cmd.Parameters.AddWithValue("@seller", User.Email);

            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    Art art = new Art();
                    art.Product_code = reader.GetValue(0).ToString();
                    art.Name = reader.GetValue(1).ToString();
                    art.Catagory = reader.GetValue(2).ToString();
                    art.Price = reader.GetValue(3).ToString();
                    art.Seller = reader.GetValue(4).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        art.Buyer = reader.GetValue(5).ToString();
                    }
                    art.Status = reader.GetValue(6).ToString();
                    art.Art_image = GetPhoto((byte[])reader.GetValue(7));

                    artList.Add(art);
                }
            }

            connection.Close();
            return artList;
        }

        public static List<Art> GetSoldArt()
        {

            List<Art> artList = new List<Art>();
            string sld = "Sold";
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @sld and Seller = @seller";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@sld", sld);
            cmd.Parameters.AddWithValue("@seller", User.Email);

            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    Art art = new Art();
                    art.Product_code = reader.GetValue(0).ToString();
                    art.Name = reader.GetValue(1).ToString();
                    art.Catagory = reader.GetValue(2).ToString();
                    art.Price = reader.GetValue(3).ToString();
                    art.Seller = reader.GetValue(4).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        art.Buyer = reader.GetValue(5).ToString();
                    }
                    art.Status = reader.GetValue(6).ToString();
                    art.Art_image = GetPhoto((byte[])reader.GetValue(7));

                    artList.Add(art);
                }
            }

            connection.Close();
            return artList;
        }

        public static List<Art> GetBoughtArt()
        {

            List<Art> artList = new List<Art>();
            string sld = "Sold";
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @sld and Buyer = @buyer";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@sld", sld);
            cmd.Parameters.AddWithValue("@buyer", User.Email);

            reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    Art art = new Art();
                    art.Product_code = reader.GetValue(0).ToString();
                    art.Name = reader.GetValue(1).ToString();
                    art.Catagory = reader.GetValue(2).ToString();
                    art.Price = reader.GetValue(3).ToString();
                    art.Seller = reader.GetValue(4).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        art.Buyer = reader.GetValue(5).ToString();
                    }
                    art.Status = reader.GetValue(6).ToString();
                    art.Art_image = GetPhoto((byte[])reader.GetValue(7));

                    artList.Add(art);
                }
            }

            connection.Close();
            return artList;
        }

        public static Art GetSpecificArt(string product_code)
        {


            string query = "SELECT * FROM ART_TBL WHERE Product_code = @code";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@code", product_code);

            reader = cmd.ExecuteReader();

            Art art = new Art();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    art.Product_code = reader.GetValue(0).ToString();
                    art.Name = reader.GetValue(1).ToString();
                    art.Catagory = reader.GetValue(2).ToString();
                    art.Price = reader.GetValue(3).ToString();
                    art.Seller = reader.GetValue(4).ToString();
                    if (!DBNull.Value.Equals(reader.GetValue(5)))
                    {
                        art.Buyer = reader.GetValue(5).ToString();
                    }
                    art.Status = reader.GetValue(6).ToString();
                    art.Art_image = GetPhoto((byte[])reader.GetValue(7));

     
                }
            }

            connection.Close();
            return art;
        }

        public static bool DeleteArt(string code)
        {
            string query = "DELETE FROM ART_TBL WHERE Product_code = @code";
            cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@code",code);

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
            connection.Close();

            return n > 0 ? true : false;

        }
        private static byte[] GetRawPhoto(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, image.RawFormat);

            return stream.GetBuffer();
        }

        private static Image GetPhoto(byte[] p)
        {

            MemoryStream stream = new MemoryStream(p);

            return Image.FromStream(stream);

        }
    }
}