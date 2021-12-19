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
using System.Net.Mail;
using System.Net;

namespace Gallery
{
    public partial class ContactForm : Form
    {
        public bool mainForm { set; get; }
        public bool profileForm { set; get; }

        public Size Psize { get; set; }

        public bool loginForm { set; get; }
        public ContactForm()
        {
            InitializeComponent();
        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainForm == true)
            {
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
            else if (profileForm == true)
            {
                ProfileForm form = new ProfileForm();
                form.Size = this.Psize;
                form.MinimumSize = this.Psize;
                form.MaximumSize = this.Psize;
                form.ShowDialog();
                this.Close();

            }
            else if (loginForm == true)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                SignUpFrom signup = new SignUpFrom();
                signup.ShowDialog();
                this.Close();
            }
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm contactForm = new AboutUsForm();
            contactForm.loginForm = this.loginForm;
            contactForm.mainForm = this.mainForm;
            contactForm.profileForm = this.profileForm;
            contactForm.Psize = this.Psize;
            contactForm.ShowDialog();
            this.Close();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            ContactFormPanel.Parent = ContactFormBG;
            ContactFormPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            //MessageBoxPanel.Parent = ContactFormBG;
            //MessageBoxPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(mailBox.Text) && !string.IsNullOrEmpty(msgBox.Text))
            {
                if (IsValidEmailAddress(mailBox.Text) == true)
                {

                    Message msg = new Message();
                    msg.Email = mailBox.Text.ToString();
                    msg.Name = nameBox.Text.ToString();
                    msg.User_Message = msgBox.Text.ToString();

                    DatabaseHelper.connection.Open();
                    if (DatabaseHelper.SendMsg(msg) == true)
                    {
                        MessageBox.Show("Thanks for contact, Stay with us!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Faild to contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid email address", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               
            }
        }
            public static bool IsValidEmailAddress(string address)
            {
                return new EmailAddressAttribute().IsValid(address);
            }

            private void ServicesBtn_Click(object sender, EventArgs e)
            {

                this.Hide();
                ServiceForm contactForm = new ServiceForm();
                contactForm.loginForm = this.loginForm;
                contactForm.mainForm = this.mainForm;
                contactForm.profileForm = this.profileForm;
                contactForm.Psize = this.Psize;
                contactForm.ShowDialog();
                this.Close();
            }
        }
    } 
