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
            else
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            if (mainForm == true)
            {
                contactForm.mainForm = true;
            }
            else
            {
                contactForm.mainForm = false;
            }
            contactForm.ShowDialog();
            this.Close();
        }

        private void AboutUsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void AboutUsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
