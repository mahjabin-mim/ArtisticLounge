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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227);

            ProfilePanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            userDashFlow.Dock = DockStyle.Fill;

            //.................... test code.............

            userDashFlow.Controls.Clear();

            Label label = new Label();
            label.Text = "On Stock";
            label.TextAlign = ContentAlignment.MiddleLeft;
            userDashFlow.Controls.Add(label);


            userDashFlow.Height = 0;

            userDashFlow.Dock = DockStyle.Fill;

            ArtOnStockCard[] artCards = new ArtOnStockCard[10];

            for (int i = 0; i < 5; i++)
            {
                artCards[i] = new ArtOnStockCard();

                userDashFlow.Controls.Add(artCards[i]);
            }

/*
            Label label2 = new Label();
            label2.Text = "On Stock";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Text = "Solt items";

            userDashFlow.Controls.Add(label2);

            for (int i = 5; i < 10; i++)
            {
                artCards[i] = new ArtOnStockCard();

                userDashFlow.Controls.Add(artCards[i]);
            }*/

            //....................

        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void MobileLabel2_Click(object sender, EventArgs e)
        {

        }

        
        private void BackToMainForm_Click_1(object sender, EventArgs e)
        {

            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;



            if (this.WindowState == FormWindowState.Maximized)
            {
                mainForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                mainForm.Size = this.Size;
            }


            mainForm.ShowDialog();

            this.Close();
        }
    }
}
