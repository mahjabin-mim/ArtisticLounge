using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Gallery
{
    class DatabaseHelper
    {
        public static string cs = ConfigurationManager.ConnectionStrings["ALDB"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(cs);
        private static SqlCommand cmd;
        private static SqlDataReader reader;
        private static DataTable dataTable;
        private static SqlDataAdapter adapter;

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

            if (usr.Password != null)
            {
                string query = "UPDATE USER_TBL SET Pass = @pass, Name = @name, Gender = @gender, Location = @loc, Phone = @phone, Picture = @pic WHERE Email = @email";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", User.Email);
                cmd.Parameters.AddWithValue("@name", usr.Name);
                cmd.Parameters.AddWithValue("@gender", usr.Gender);
                cmd.Parameters.AddWithValue("@loc", usr.Location);
                cmd.Parameters.AddWithValue("@phone", usr.Phone);
                cmd.Parameters.AddWithValue("@pass", usr.Password);
                cmd.Parameters.AddWithValue("@pic", GetRawPhoto(usr.Picture));
            }
            else
            {
                string query = "UPDATE USER_TBL SET Name = @name, Gender = @gender, Location = @loc, Phone = @phone, Picture = @pic WHERE Email = @email";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", User.Email);
                cmd.Parameters.AddWithValue("@name", usr.Name);
                cmd.Parameters.AddWithValue("@gender", usr.Gender);
                cmd.Parameters.AddWithValue("@loc", usr.Location);
                cmd.Parameters.AddWithValue("@phone", usr.Phone);
                cmd.Parameters.AddWithValue("@pic", GetRawPhoto(usr.Picture));
            }

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show(e.Message);
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
            string st = "Available";
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @avl";
            cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@avl",st);

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

        public static bool DeleteArtWithEmail(string email)
        {
            
            string query = "DELETE FROM ART_TBL WHERE Seller = @email";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email);

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

        public static bool UpdateArt(string code)
        {
            string status = "Sold";
            string query = "UPDATE ART_TBL SET Art_status = @sold, Buyer = @email WHERE Product_code = @code";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@sold", status);
            cmd.Parameters.AddWithValue("@email", User.Email);

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

        public static DataTable BindUsers()
        {
            string query = "SELECT * FROM USER_TBL";
            adapter = new SqlDataAdapter(query, connection);

             dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
            catch
            {
                connection.Close();
                return null;
            }
            
        }
        public static bool UpdatePendingArts(string code)
        {
            string status = "Available";
            string query = "UPDATE ART_TBL SET Art_status = @avl WHERE Product_code = @code";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@avl", status);

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch
            {
                connection.Close();
                return false;
            }
            connection.Close();

            return n > 0 ? true : false;
        }

        public static DataTable BindPendingArts()
        {
            string st = "Pending";
            string query = "SELECT * FROM ART_TBL WHERE Art_status = @pend";
            adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@pend", st);

            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }

        public static bool AcceptArt(string code)
        {

            string status = "Available";
            string query = "UPDATE ART_TBL SET Art_status = @sold WHERE Product_code = @code";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@sold", status);

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

        public static bool DeleteUser(string email)
        {
            string query = "DELETE FROM USER_TBL WHERE Email = @email";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email);

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch
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


        public static bool SendMsg(Message msg)
        {
            string query = "INSERT INTO MSG_TBL VALUES (next value for MSG_SQ,@name,@mail,@msg)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", msg.Name);
            cmd.Parameters.AddWithValue("@mail", msg.Email);
            cmd.Parameters.AddWithValue("@msg", msg.User_Message);
          

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


        public static DataTable BindMsg()
        {
            string query = "SELECT * FROM MSG_TBL";
            adapter = new SqlDataAdapter(query, connection);

            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                connection.Close();
                return dataTable;
            }
            catch
            {
                connection.Close();
                return null;
            }

        }

        public static bool DeleteMessage(string msg)
        {
            string query = "DELETE FROM MSG_TBL WHERE MsgCount = @msgNo";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@msgNo", msg);

            int n = 0;

            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch
            {
                connection.Close();
                return false;
            }
            connection.Close();

            return n > 0 ? true : false;
        }

        public static bool DeleteMsgWithNo(string msgNo)
        {
            string query = "DELETE FROM MSG_TBL WHERE MsgCount = @msgNo";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@msgNo", msgNo);

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
    }
}