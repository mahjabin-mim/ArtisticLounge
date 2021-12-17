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
    public partial class MessageForm : Form
    {
        private static DataTable dataTable;
        private int selectedIndex = -1;
        public MessageForm()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
            this.Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            msgGridView.AllowUserToAddRows = false;
            msgGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            msgGridView.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            msgGridView.ClearSelection();

            BindMsg();
        }

        private void msgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BindMsg()
        {
            DatabaseHelper.connection.Open();
            dataTable = DatabaseHelper.BindMsg();

            if (dataTable != null)
            {
                this.msgGridView.DataSource = dataTable;
                msgGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedIndex != -1)
            {
                string msgNo = msgGridView.Rows[selectedIndex].Cells[0].Value.ToString();
                string name = msgGridView.Rows[selectedIndex].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("Do you want to Delete " + name + "'s message", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.connection.Open();

                    if (DatabaseHelper.DeleteMessage(msgNo) == true)
                    {
                        DatabaseHelper.connection.Open();
                        DatabaseHelper.DeleteMsgWithNo(msgNo);
                        MessageBox.Show("Message delete successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BindMsg();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting message", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Ërror");
                }
            }
        }
    }
}
