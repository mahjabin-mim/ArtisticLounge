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

    public partial class Form1 : Form
    {
        private bool showPass = false;
        public Form1()
        {


            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Parent = pictureBox1;
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;

            AboutUsBtn.Cursor = Cursors.Hand;
            ContactBtn.Cursor = Cursors.Hand;
            ServicesBtn.Cursor = Cursors.Hand;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            // changing sign up color
            signUpLabel.ForeColor = Color.White;
            signUpUnderPanel.BackColor = Color.Transparent;

            //hide signup options


            //show login options
            loginEmail.Visible = true;
            loginPass.Visible = true;
            loginBtn.Visible = true;

            //change login color
            loginLabel.ForeColor = Color.FromArgb(1, 0, 0, 192);
            loginUnderPanel.BackColor = Color.Navy;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUpFrom signUpFrom = new SignUpFrom();
            signUpFrom.StartPosition = FormStartPosition.Manual;
            signUpFrom.Location = this.Location;
            //signUpFrom.Size = this.Size;

            signUpFrom.ShowDialog();

            this.Close();

        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {

            if (!showPass)
            {
                showPassBtn.Image = Properties.Resources.open;
                showPass = true;
                
                switch (showPass)
                {
                    case true: loginPass.UseSystemPasswordChar = false; break;
                    default: loginPass.UseSystemPasswordChar = true; break;
                }

            }
            else
            {
                showPassBtn.Image = Properties.Resources.hidden__1_;
                showPass = false;

                switch (showPass)
                {
                    case false: loginPass.UseSystemPasswordChar = true; break;
                    default: loginPass.UseSystemPasswordChar = false; break;
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginEmail.Text) || !string.IsNullOrEmpty(loginPass.Text))
            {
                DatabaseHelper.connection.Open();
                User user = new User();
                User.Email = loginEmail.Text.ToString();
                user.Password = loginPass.Text.ToString();

                if (DatabaseHelper.LoginForm(user) == true)
                {
                   
                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();
                    this.Close();
                }
                else if (loginEmail.Text.Equals("a.admin") && loginPass.Text.Equals("123"))
                {
                    this.Hide();

                    AdminForm admin = new AdminForm();
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Enter your Email & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
            {
                 this.Hide();
                 AboutUsForm aboutUsForm = new AboutUsForm();
                 aboutUsForm.loginForm = true;
                 aboutUsForm.mainForm = false;
                 aboutUsForm.profileForm = false;
                 aboutUsForm.Psize = this.Size;
                 aboutUsForm.ShowDialog();
                 this.Close();

            }

        private void ContactBtn_Click(object sender, EventArgs e)
            {
                this.Hide();
                ContactForm contactForm = new ContactForm();
                contactForm.loginForm = true;
                contactForm.mainForm = false;
                contactForm.profileForm = false;
                contactForm.Psize = this.Size;
                contactForm.ShowDialog();
                this.Close();
            }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginEmail.Text))
            {
                errorProvider1.Icon = Properties.Resources.check;
                errorProvider1.BlinkRate = 0;
                errorProvider1.SetError(loginEmail, "Correct");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void loginPass_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginPass.Text))
            {
                errorProvider2.Icon = Properties.Resources.check;
                errorProvider2.BlinkRate = 0;
                errorProvider2.SetError(loginPass, "Correct");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void loginPass_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginEmail.Text))
            {
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(loginEmail, "Enter your Email first");
                loginEmail.Focus();
            }
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.loginForm = true;
            serviceForm.mainForm = false;
            serviceForm.profileForm = false;
            serviceForm.Psize = this.Size;
            serviceForm.ShowDialog();
            this.Close();
        }
    } 

    }

