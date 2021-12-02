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
    public partial class PostArtForm : Form
    {
        public PostArtForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PostArtForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227);

            //panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            //panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            /*  mainForm.StartPosition = FormStartPosition.Manual;
              mainForm.Location = this.Location;*/


            /*
                        if (this.WindowState == FormWindowState.Maximized)
                        {
                            mainForm.WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            mainForm.Size = this.Size;
                        }*/


            mainForm.ShowDialog();

            this.Close();
        }
    }
}
