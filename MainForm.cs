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
        public MainForm()
        {
            InitializeComponent();
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

            cb1.Parent = sliderBox;
            cb2.Parent = sliderBox;
            cb3.Parent = sliderBox;
            cb4.Parent = sliderBox;
            cb5.Parent = sliderBox;

            cb1.Checked = true;

            //.................... test code.............

           // mainPanel.Controls.Clear();

            dropDownPanel.Height = 0;

            mainPanel.Dock = DockStyle.Fill;

            ArtCard[] artCards = new ArtCard[30];

            for (int i = 0; i < artCards.Length; i++)
            {
                artCards[i] = new ArtCard();
                artCards[i].parentForm = this;
                

                mainPanel.Controls.Add(artCards[i]);

                
            }

            //....................
          
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
            profileForm.StartPosition = FormStartPosition.Manual;
            profileForm.Location = this.Location;

            if (this.Size.Height >= profileForm.MinimumSize.Height &&
                this.Size.Width >= profileForm.MaximumSize.Width)
            {
                profileForm.Size = this.Size;
            }


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


    }
}
