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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdminPanel.Parent = pictureBox2;
            //this.BackColor = Color.FromArgb(138, 175, 227);
            AdminPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            //form1.StartPosition = FormStartPosition.Manual;
            //form1.Location = this.Location;
            //form1.Size = this.Size;



            form1.ShowDialog();

            this.Close();
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm userFrom = new UsersForm();
            userFrom.ShowDialog();
            this.Close();
        }

        private void PendingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingArtForm pendingForm = new PendingArtForm();
            pendingForm.ShowDialog();
            this.Close();
        }

        private void MsgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageForm messageFrom = new MessageForm();
            messageFrom.ShowDialog();
            this.Close();
        }
    }
}
