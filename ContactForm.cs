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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
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

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.StartPosition = FormStartPosition.Manual;
            aboutUsForm.Location = this.Location;
            aboutUsForm.Size = this.Size;

            aboutUsForm.ShowDialog();
            this.Close();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            ContactFormPanel.Parent = ContactFormBG;
            ContactFormPanel.BackColor = Color.FromArgb(100,0,0,0);
        }
    }
}
