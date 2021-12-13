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
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227);

            EditPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            loadData();
        }

        private void loadData()
        {
            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(User.Email);

            if (user != null)
            {
                nameTextBox.Text = user.Name;
                EditProfilePicture.Image = user.Picture;

                genderTextBox.Text = user.Gender;
                locationTextBox.Text = user.Location;
                phoneTextBox.Text = user.Phone;
            }


        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Image";
            dialog.Filter = "IMAGE FILE (*.*) | *.*";
           

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                EditProfilePicture.Image = new Bitmap(dialog.FileName);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EditProfilePicture.Image = Properties.Resources.user2;
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileForm profileForm = new ProfileForm();
           /* profileForm.StartPosition = FormStartPosition.Manual;
            profileForm.Location = this.Location;*/

            profileForm.ShowDialog();

            this.Close();
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
           
            user.Name = nameTextBox.Text;
            user.Gender = genderTextBox.Text;
            user.Location = locationTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Picture = EditProfilePicture.Image;

            DatabaseHelper.connection.Open();

            if (DatabaseHelper.UpdateUser(user) == true)
            {
                MessageBox.Show("User updated "+user.Name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Update error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
