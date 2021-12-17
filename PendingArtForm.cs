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
    public partial class PendingArtForm : Form
    {
        private static DataTable dataTable;
        private int selectedIndex = -1;
        public PendingArtForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void PendingArtForm_Load(object sender, EventArgs e)
        {
            artsGridView.AllowUserToAddRows = false;
            artsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            artsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            artsGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            artsGridView.ClearSelection();
            BindArts();
        }

        private void BindArts()
        {
            DatabaseHelper.connection.Open();
            dataTable = DatabaseHelper.BindPendingArts();

            if (dataTable != null)
            {
                this.artsGridView.DataSource = dataTable;

                DataGridViewImageColumn imageColum = new DataGridViewImageColumn();
                imageColum = (DataGridViewImageColumn)artsGridView.Columns[7];
                imageColum.ImageLayout = DataGridViewImageCellLayout.Stretch;

                artsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //usersGridView.RowTemplate.Height = 150;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = string.Format("Art_name like '%{0}%'", searchBox.Text);
            this.artsGridView.DataSource = dv.ToTable();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
            this.Close();
        }

        private void artsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

       

        private void artsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                artsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Navy;
                artsGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void artsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                artsGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                artsGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

            }
        }

        private void artsGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           // artsGridView.Rows[0].Selected = false;
            artsGridView.ClearSelection();
            
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1)
            {
                string code = artsGridView.Rows[selectedIndex].Cells[0].Value.ToString();

                DatabaseHelper.connection.Open();

                if (DatabaseHelper.AcceptArt(code) == false)
                {
                    MessageBox.Show("Error accepting art", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BindArts();
                }
                
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1)
            {
                string code = artsGridView.Rows[selectedIndex].Cells[0].Value.ToString();
                string artName = artsGridView.Rows[selectedIndex].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Do you want to Delete " + artName, "Delete art", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.connection.Open();

                    if (DatabaseHelper.DeleteArt(code) == true)
                    {
                        MessageBox.Show("Art delete successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BindArts();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting art", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }


            }
        }
    }
}
