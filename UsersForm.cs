using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class UsersForm : Form
    {
        private static DataTable dataTable;
        private int selectedIndex = -1;
        public UsersForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            usersGridView.AllowUserToAddRows = false;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usersGridView.ClearSelection();

            BindUsers();
        }

        private void BindUsers()
        {
           DatabaseHelper.connection.Open();
           dataTable = DatabaseHelper.BindUsers();

           if (dataTable != null)
           {
               this.usersGridView.DataSource = dataTable;

               DataGridViewImageColumn imageColum = new DataGridViewImageColumn();
               imageColum = (DataGridViewImageColumn)usersGridView.Columns[6];
               imageColum.ImageLayout = DataGridViewImageCellLayout.Stretch;

               usersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
               //usersGridView.RowTemplate.Height = 150;
           }
        }

       

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%'", searchBox.Text);
            this.usersGridView.DataSource = dv.ToTable();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
            this.Close();
        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void usersGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex > -1)
            {
                usersGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Navy;
                usersGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }*/
        }

        private void usersGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex > -1)
            {
                usersGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                usersGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                
            }*/
            
        }

        private void usersGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // usersGridView.Rows[0].Selected = false;
            usersGridView.ClearSelection();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1)
            {
                string email = usersGridView.Rows[selectedIndex].Cells[0].Value.ToString();
                string name = usersGridView.Rows[selectedIndex].Cells[2].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to Delete " + name, "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.connection.Open();

                    if (DatabaseHelper.DeleteUser(email) == true)
                    {
                        DatabaseHelper.connection.Open();
                        DatabaseHelper.DeleteArtWithEmail(email);
                        MessageBox.Show("User delete successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BindUsers();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting user", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    }
                }
            }
        }
    }
}
