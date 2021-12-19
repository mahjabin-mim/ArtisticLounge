using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
namespace Gallery
{
    public partial class SignUpFrom : Form
    {
        private bool showPass = false;
        public SignUpFrom()
        {
            InitializeComponent();


        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;

            form1.ShowDialog();
            this.Close();
        }

        private void SignUpFrom_Load(object sender, EventArgs e)
        {
            signupRightPanel.Parent = signupPictureBox;
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;

            AboutUsBtn.Cursor = Cursors.Hand;
            ContactBtn.Cursor = Cursors.Hand;
            ServicesBtn.Cursor = Cursors.Hand;
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {

            if (!showPass)
            {
                showPassBtn.Image = Properties.Resources.open;
                showPass = true;

                switch (showPass)
                {
                    case true: signupPass.UseSystemPasswordChar = false; break;
                    default: signupPass.UseSystemPasswordChar = true; break;
                }

            }
            else
            {
                showPassBtn.Image = Properties.Resources.hidden__1_;
                showPass = false;

                switch (showPass)
                {
                    case false: signupPass.UseSystemPasswordChar = true; break;
                    default: signupPass.UseSystemPasswordChar = false; break;
                }
            }
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {

        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {

        }

        private void AboutusBtn_Click(object sender, EventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(signupEmail.Text) || !string.IsNullOrEmpty(signupName.Text) || !string.IsNullOrEmpty(signupPass.Text))
            {
                if (IsValidEmailAddress(signupEmail.Text) == true)
                {

                    User user = new User();
                    User.Email = signupEmail.Text.ToString();
                    user.Name = signupName.Text.ToString();
                    user.Password = signupPass.Text.ToString();

                    DatabaseHelper.connection.Open();
                    if (DatabaseHelper.SignUpFrom(user) == true)
                    {
                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid email address", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            else
            {
                MessageBox.Show("Fill up box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static bool IsValidEmailAddress(string address)
        {
            return new EmailAddressAttribute().IsValid(address);
        }

        private void AboutUsBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.loginForm = false;
            aboutUsForm.mainForm = false;
            aboutUsForm.profileForm = false;
            aboutUsForm.Psize = this.Size;
            aboutUsForm.ShowDialog();
            this.Close();
        }

        private void ContactBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            contactForm.loginForm = false;
            contactForm.mainForm = false;
            contactForm.profileForm = false;
            contactForm.Psize = this.Size;
            contactForm.ShowDialog();
            this.Close();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.loginForm = false;
            serviceForm.mainForm = false;
            serviceForm.profileForm = false;
            serviceForm.Psize = this.Size;
            serviceForm.ShowDialog();
            this.Close();
        }
    }
}
