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
        public Size Psize { get; set; }
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
            profileForm.Size = this.Psize;
            profileForm.MinimumSize = this.Psize;
            profileForm.MaximumSize = this.Psize;

            profileForm.ShowDialog();

            this.Close();
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            bool canUpdate = true;
            User user = new User();
            user.Name = nameTextBox.Text;
            user.Gender = genderTextBox.Text;
            user.Location = locationTextBox.Text;
            user.Phone = phoneTextBox.Text;
            user.Picture = EditProfilePicture.Image;

            if (!string.IsNullOrEmpty(currentPassTextBox.Text) && !string.IsNullOrEmpty(newPassTextBox.Text))
            {
                User checkUser = new User();
                checkUser.Password = currentPassTextBox.Text.ToString();

                DatabaseHelper.connection.Open();
                if (DatabaseHelper.LoginForm(checkUser) == true)
                {
                    user.Password = newPassTextBox.Text;
                }
                else
                {
                    user.Password = null;
                    canUpdate = false;
                }
                
            }

            if (canUpdate == true)
            {
                DatabaseHelper.connection.Open();

                if (DatabaseHelper.UpdateUser(user) == true)
                {
                    MessageBox.Show("Profile updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToMainForm_Click(null, null);

                }
                else
                {

                    MessageBox.Show("Update error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Your current password is wrong!", "Password error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void newPassTextBox_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPassTextBox.Text.ToString()))
            {
                errorProvider1.Clear();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.BlinkRate = 0;
                errorProvider1.SetError(currentPassTextBox, "Please select current password!");
                currentPassTextBox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void showCurrentPassBtn_Click(object sender, EventArgs e)
        {
            if (currentPassTextBox.UseSystemPasswordChar == true)
            {
                currentPassTextBox.UseSystemPasswordChar = false;
                showCurrentPassBtn.Image = Properties.Resources.open;
            }
            else
            {
                currentPassTextBox.UseSystemPasswordChar = true;
                showCurrentPassBtn.Image = Properties.Resources.hidden__1_;
            }
        }

        private void showNewPassBtn_Click(object sender, EventArgs e)
        {
            if (newPassTextBox.UseSystemPasswordChar == true)
            {
                newPassTextBox.UseSystemPasswordChar = false;
                showNewPassBtn.Image = Properties.Resources.open;
            }
            else
            {
                newPassTextBox.UseSystemPasswordChar = true;
                showNewPassBtn.Image = Properties.Resources.open;
            }
        }
    }
}
