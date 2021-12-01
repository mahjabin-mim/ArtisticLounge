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

            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;

            form1.ShowDialog();
            this.Close();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            contactForm.StartPosition = FormStartPosition.Manual;
            contactForm.Location = this.Location;
            //contactForm.Size = this.Size;

            contactForm.ShowDialog();
            this.Close();
        }
    }
}
