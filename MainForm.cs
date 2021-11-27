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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //guna2GradientPanel1.BackColor = Color.White;
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AboutusBtn_Click(object sender, EventArgs e)
        {

        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {

        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //.................... test code.............

            mainPanel.Controls.Clear();
           
            mainPanel.Dock = DockStyle.Fill;

            ArtCard[] artCards = new ArtCard[30];

            for (int i = 0; i < artCards.Length; i++)
            {
                artCards[i] = new ArtCard();

                mainPanel.Controls.Add(artCards[i]);
            }

            //....................
          
        }

        private void MainFlowPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
