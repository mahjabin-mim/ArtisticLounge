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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            ProfilePanel.Parent = ProfileFormBG;
            ProfilePanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void MobileLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {

            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;
            mainForm.Size = this.Size;

            mainForm.ShowDialog();

            this.Close();

  
        }

        /*private void EditBtnMouseEnter(object sender, EventArgs e)
        {
            EditProfileBtn.BackColor = Color.White;
            EditProfileBtn.ForeColor = Color.Black;
        }

        private void EditBtnMousOut(object sender, EventArgs e)
        {
            EditProfileBtn.BackColor = Color.Black;
            EditProfileBtn.ForeColor = Color.White;
        }*/
    }
}
