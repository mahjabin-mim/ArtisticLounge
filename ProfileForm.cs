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

            loadProfile();

            //.................... test code.............

            userDashFlow.Controls.Clear();
            userDashFlow.Dock = DockStyle.Fill;


            loadAllArts();
           

        }


        private void loadProfile()
        {
            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(User.Email);

            if (user != null)
            {
                ProfileName.Text = user.Name;
                ProfilePicture.Image = user.Picture;
                EmailLabel2.Text = User.Email;
                GenderLabel2.Text = user.Gender;
                LocationLabel2.Text = user.Location;
                MobileLabel2.Text = user.Phone;
            }
        }

        public void loadAllArts()
        {
            userDashFlow.Controls.Clear();

            loadStockArt();

            loadSoldArt();

            loadBoughtArt();
        }
        public void loadStockArt()
        {

            DatabaseHelper.connection.Open();
            List<Art> artList = DatabaseHelper.GetStockArt();

            Label stockLabel = new Label();

            stockLabel.BackColor = System.Drawing.Color.Transparent;
            stockLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.ForeColor = System.Drawing.Color.Navy;

            stockLabel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);

            stockLabel.Name = "stockLabel";
            stockLabel.TabIndex = 0;
            stockLabel.Text = "On Stock";
            stockLabel.AutoSize = false;
            stockLabel.Size = new Size(userDashFlow.Width, 30);
            stockLabel.Dock = DockStyle.Top;


            userDashFlow.Controls.Add(stockLabel);

            if (artList.Count > 0)
            {
                //...............sold items

                for (int i = 0; i < artList.Count; i++)
                {
                    ArtOnStockCard card = new ArtOnStockCard();
                    card.art_code = artList[i].Product_code;
                    card.image = artList[i].Art_image;
                    card.title = artList[i].Name;
                    card.price = artList[i].Price;
                    card.parentForm = this;

                    userDashFlow.Controls.Add(card);
                }
            }

            else
            {
                Label noItem = new Label();

                noItem.BackColor = System.Drawing.Color.Transparent;
                noItem.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                noItem.ForeColor = System.Drawing.Color.Gray;

                noItem.Margin = new System.Windows.Forms.Padding(20, 25, 3, 0);

                noItem.Name = "noItem";
                noItem.TabIndex = 0;
                noItem.Text = "No Items";
                noItem.AutoSize = false;
                noItem.Size = new Size(userDashFlow.Width, 30);
                noItem.Dock = DockStyle.Top;


                userDashFlow.Controls.Add(noItem);

            }
        }

        public void loadSoldArt()
        {

            DatabaseHelper.connection.Open();
            List<Art> artList = DatabaseHelper.GetSoldArt();

            Label soldLabel = new Label();

            soldLabel.BackColor = System.Drawing.Color.Transparent;
            soldLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soldLabel.ForeColor = System.Drawing.Color.Navy;

            soldLabel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);

            soldLabel.Name = "categoryLabel";
            soldLabel.TabIndex = 0;
            soldLabel.Text = "Sold Items";
            soldLabel.AutoSize = false;
            soldLabel.Size = new Size(userDashFlow.Width, 30);
            soldLabel.Dock = DockStyle.Top;


            userDashFlow.Controls.Add(soldLabel);

            if (artList.Count > 0)
            {
                //...............sold items

                for (int i = 0; i < artList.Count; i++)
                {
                    ArtOnStockCard card = new ArtOnStockCard();
                    card.art_code = artList[i].Product_code;
                    card.image = artList[i].Art_image;
                    card.title = artList[i].Name;
                    card.price = artList[i].Price;
                    card.parentForm = this;

                    userDashFlow.Controls.Add(card);
                }
            }

            else
            {
                Label noItem = new Label();

                noItem.BackColor = System.Drawing.Color.Transparent;
                noItem.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                noItem.ForeColor = System.Drawing.Color.Gray;

                noItem.Margin = new System.Windows.Forms.Padding(20, 25, 3, 0);

                noItem.Name = "noItem";
                noItem.TabIndex = 0;
                noItem.Text = "No Items";
                noItem.AutoSize = false;
                noItem.Size = new Size(userDashFlow.Width, 30);
                noItem.Dock = DockStyle.Top;


                userDashFlow.Controls.Add(noItem);

            }
        }

        public void loadBoughtArt()
        {

            DatabaseHelper.connection.Open();
            List<Art> artList = DatabaseHelper.GetBoughtArt();

            Label boughtLabel = new Label();

            boughtLabel.BackColor = System.Drawing.Color.Transparent;
            boughtLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boughtLabel.ForeColor = System.Drawing.Color.Navy;

            boughtLabel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);

            boughtLabel.Name = "boughtLabel";
            boughtLabel.TabIndex = 0;
            boughtLabel.Text = "Bought Items";
            boughtLabel.AutoSize = false;
            boughtLabel.Size = new Size(userDashFlow.Width, 35);
            boughtLabel.Dock = DockStyle.Top;


            userDashFlow.Controls.Add(boughtLabel);

            if (artList.Count > 0)
            {
                //...............sold items

                for (int i = 0; i < artList.Count; i++)
                {
                    ArtOnStockCard card = new ArtOnStockCard();
                    card.art_code = artList[i].Product_code;
                    card.image = artList[i].Art_image;
                    card.title = artList[i].Name;
                    card.price = artList[i].Price;
                    card.parentForm = this;

                    userDashFlow.Controls.Add(card);
                }
            }

            else
            {
                Label noItem = new Label();

                noItem.BackColor = System.Drawing.Color.Transparent;
                noItem.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                noItem.ForeColor = System.Drawing.Color.Gray;

                noItem.Margin = new System.Windows.Forms.Padding(20, 25, 3, 0);

                noItem.Name = "noItem";
                noItem.TabIndex = 0;
                noItem.Text = "No Items";
                noItem.AutoSize = false;
                noItem.Size = new Size(userDashFlow.Width, 30);
                noItem.Dock = DockStyle.Top;


                userDashFlow.Controls.Add(noItem);

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
            editProfileForm.Psize = this.MinimumSize;

            editProfileForm.ShowDialog();

            this.Close();
        }
    }
}
