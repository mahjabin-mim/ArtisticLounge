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
    public partial class ServiceForm : Form
    {
        public bool mainForm { set; get; }
        public bool profileForm { set; get; }
        public Size Psize { get; set; }
        public ServiceForm()
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
            else
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            ServicePanel.Parent = ServiceFormBG;
            ServicePanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            AboutUsForm contactForm = new AboutUsForm();
            contactForm.mainForm = this.mainForm;
            contactForm.profileForm = this.profileForm;
            contactForm.Psize = this.Psize;
            contactForm.ShowDialog();
            this.Close();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            contactForm.mainForm = this.mainForm;
            contactForm.profileForm = this.profileForm;
            contactForm.Psize = this.Psize;
            contactForm.ShowDialog();
            this.Close();
        }
    }
}
