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
        private bool isCollapsed = false;
        private int ImageNumber = 0;
        private Image[] images = { Properties.Resources.art2,Properties.Resources.art3,Properties.Resources.art4,
                                    Properties.Resources.art5,Properties.Resources.art6};
        private List<Art> artList;
        public MainForm()
        {
            InitializeComponent();
            artList = new List<Art>();
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
            prevBtn.Parent = sliderBox;
            nextBtn.Parent = sliderBox;
            sliderBox.Image = images[ImageNumber];
            sliderBox.Width = mainPanel.Width - 29;

            cb1.Parent = sliderBox;
            cb2.Parent = sliderBox;
            cb3.Parent = sliderBox;
            cb4.Parent = sliderBox;
            cb5.Parent = sliderBox;

            cb1.Checked = true;

            

            dropDownPanel.Height = 0;

            mainPanel.Dock = DockStyle.Fill;

            LoadUserImage();

            LoadAllArts();

           
          
        }

        private void LoadUserImage()
        {
            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(User.Email);

            if (user != null)
            {
                guna2CirclePictureBox1.Image = user.Picture;
            }
        }

        private void LoadAllArts()
        {
            DatabaseHelper.connection.Open();

            artList = DatabaseHelper.GetArt();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(sliderBox);

            if (artList.Count > 0)
            {
                for (int i = 0; i < artList.Count; i++)
                {

                    ArtCard card = new ArtCard();
                    card.art_code = artList[i].Product_code;
                    card.image = artList[i].Art_image;
                    card.title = artList[i].Name;
                    card.price = artList[i].Price;
                    card.parentForm = this;

                    mainPanel.Controls.Add(card);
                    

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
                noItem.Size = new Size(sliderBox.Width, 30);
                noItem.Dock = DockStyle.Top;

                mainPanel.Controls.Add(noItem);
                
            }

           
        }

        private void LoadCategory(string category)
        {
            mainPanel.Controls.Clear();
           
            Label categoryLabel = new Label();

            categoryLabel.BackColor = System.Drawing.Color.Transparent;
            categoryLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.ForeColor = System.Drawing.Color.Navy;

            categoryLabel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);

            categoryLabel.Name = "categoryLabel";
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = category;
            categoryLabel.AutoSize = false;
            categoryLabel.Size = new Size(mainPanel.Width, 30);
            categoryLabel.Dock = DockStyle.Top;

            mainPanel.Controls.Add(categoryLabel);

            List<Art> tempList = new List<Art>();

            foreach (Art art in artList)
            {
                if (art.Catagory.Trim().Equals(category))
                {
                    tempList.Add(art);
                }
               
            }

            if (tempList.Count > 0)
            {
                foreach (Art art in tempList)
                {
                    ArtCard card = new ArtCard();
                    card.art_code = art.Product_code;
                    card.image = art.Art_image;
                    card.title = art.Name;
                    card.price = art.Price;
                    card.parentForm = this;

                    mainPanel.Controls.Add(card);
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
                noItem.Size = new Size(sliderBox.Width, 30);
                noItem.Dock = DockStyle.Top;

                mainPanel.Controls.Add(noItem);
            }

            

            
        }
   
        private void categoryBtn_Click(object sender, EventArgs e)
        {

            dropDonwTimer.Start();
        }

        private void dropDonwTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                dropDownPanel.Height += 10;

                if (dropDownPanel.Size == dropDownPanel.MaximumSize)
                {
                    dropDonwTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                dropDownPanel.Height -= 10;
                if (dropDownPanel.Size == dropDownPanel.MinimumSize)
                {
                    dropDonwTimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Size = this.Size;



            form1.ShowDialog();

            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileForm profileForm = new ProfileForm();
            profileForm.Size = new Size(this.Size.Width + 43, this.Size.Height);
            profileForm.MinimumSize = new Size(this.MinimumSize.Width + 43, this.MinimumSize.Height);
            profileForm.MaximumSize = new Size(this.MaximumSize.Width + 43, this.MaximumSize.Height);

            profileForm.ShowDialog();

            this.Close();
        }


        // slider functions

        private void LoadPrevImages()
        {
            timer1.Start();
            ImageNumber--;

            if (ImageNumber < 0)
            {
                ImageNumber = 4;
            }

            sliderBox.Image = images[ImageNumber];
            LoadCheck();
        }

        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;

            if (ImageNumber > 4)
            {
                ImageNumber = 0;
            }

            sliderBox.Image = images[ImageNumber];
            LoadCheck();
        }

        private void LoadCheck()
        {
            if (ImageNumber == 0) { cb1.Checked = true; }
            else if (ImageNumber == 1) { cb2.Checked = true; }
            else if (ImageNumber == 2) { cb3.Checked = true; }
            else if (ImageNumber == 3) { cb4.Checked = true; }
            else { cb5.Checked = true; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPrevImages();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImages();

        }

        private void ChangedCheck()
        {
            timer1.Start();
            if (cb1.Checked == true) { ImageNumber = 0; }
            else if(cb2.Checked == true) { ImageNumber = 1; }
            else if(cb3.Checked == true) { ImageNumber = 2; }
            else if(cb4.Checked == true) { ImageNumber = 3; }
            else if(cb5.Checked == true) { ImageNumber = 4; }

            sliderBox.Image = images[ImageNumber];
        }

    
        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangedCheck();
        }



        //  ..........slider function end

        private void PostBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            PostArtForm postArtform = new PostArtForm();

            postArtform.ShowDialog();

            this.Close();

        }

        private void fineArt_Click(object sender, EventArgs e)
        {
            LoadCategory(fineArt.Text);
        }

        private void vectorBtn_Click(object sender, EventArgs e)
        {
            LoadCategory(vectorBtn.Text);
        }

        private void compositionBtn_Click(object sender, EventArgs e)
        {
            LoadCategory(compositionBtn.Text);
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            LoadCategory(otherBtn.Text);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadAllArts();
        }

    }
}
