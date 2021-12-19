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
    public partial class AboutUsForm : Form
    {
        public bool mainForm { set; get; }
        public bool profileForm { set; get; }
        public Size Psize { get; set; }
        public bool loginForm { set; get; }
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void AboutUsForm_Load(object sender, EventArgs e)
        {
            AboutUsPanel.Parent = AboutUsFormBG;
            AboutUsPanel.BackColor = Color.FromArgb(100,0,0,0);
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

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            contactForm.loginForm = this.loginForm;
            contactForm.mainForm = this.mainForm;
            contactForm.profileForm = this.profileForm;
            contactForm.Psize = this.Psize;
            contactForm.ShowDialog();
            this.Close();
        }

        private void AboutUsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void AboutUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
