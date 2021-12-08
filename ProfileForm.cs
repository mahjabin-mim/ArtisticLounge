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
            userDashFlow.Dock = DockStyle.Fill;

            Label stockLabel = new Label();


            stockLabel.BackColor = System.Drawing.Color.Transparent;
            stockLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.ForeColor = System.Drawing.Color.Navy;

            stockLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);

            stockLabel.Name = "stockLabel";
            stockLabel.TabIndex = 0;
            stockLabel.Text = "On Stock";
            stockLabel.AutoSize = false;
            stockLabel.Size = new Size(1368, 30);
            stockLabel.Dock = DockStyle.Top;


            userDashFlow.Controls.Add(stockLabel);


            ArtOnStockCard[] artCards = new ArtOnStockCard[10];

            for (int i = 0; i < 5; i++)
            {
                artCards[i] = new ArtOnStockCard();

                userDashFlow.Controls.Add(artCards[i]);
            }

            //...............sold items
            Label soldLabel = new Label();

            soldLabel.BackColor = System.Drawing.Color.Transparent;
            soldLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soldLabel.ForeColor = System.Drawing.Color.Navy;

            soldLabel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);

            soldLabel.Name = "stockLabel";
            soldLabel.TabIndex = 0;
            soldLabel.Text = "Sold items";
            soldLabel.AutoSize = false;
            soldLabel.Size = new Size(1368, 30);
            soldLabel.Dock = DockStyle.Top;


            userDashFlow.Controls.Add(soldLabel);

            for (int i = 5; i < 10; i++)
            {
                artCards[i] = new ArtOnStockCard();

                userDashFlow.Controls.Add(artCards[i]);
            }


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

        private void EditProfileBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            EditProfileForm editProfileForm = new EditProfileForm();
            /* editProfileForm.StartPosition = FormStartPosition.Manual;
             editProfileForm.Location = this.Location;*/

            editProfileForm.ShowDialog();

            this.Close();
        }

        private void loadProfile()
        {
            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(User.Email);
        }
    }
}
