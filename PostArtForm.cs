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
            if (string.IsNullOrEmpty(categoryBox.Text))
            {
                errorArtCategory.Icon = Properties.Resources.error;
                errorArtCategory.BlinkRate = 0;
                errorArtCategory.SetError(categoryBox, "Please fill the Category");

            }
            else
            {
                errorArtCategory.Clear();
                categoryBox.BorderColor = Color.White;
            }
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
           

            mainForm.ShowDialog();

            this.Close();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            /*string s = "0";
            string c = priceBox.Text;*/

            if (!string.IsNullOrEmpty(artName.Text) && categoryBox.SelectedIndex > -1 && !string.IsNullOrEmpty(priceBox.Text))
            {

                DatabaseHelper.connection.Open();
                Art art = new Art();
                art.Name = artName.Text;
                art.Catagory = categoryBox.Items[categoryBox.SelectedIndex].ToString();
                art.Price = priceBox.Text.ToString();
                art.Art_image = ArtPicture.Image;
                art.Seller = User.Email;
                art.Status = "Pending"; // this will be changed to pending

                if (DatabaseHelper.PostArt(art) == true)
                {
                    MessageBox.Show("Art posted", "Post Art", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Hide();

                    MainForm mainForm = new MainForm();

                    mainForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error posting art", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                }
            }
            else
            {
               
                if (string.IsNullOrEmpty(artName.Text))
                {
                    artName.BorderColor = Color.Red;
                    //  emailError.Clear();
                    errorArtName.Icon = Properties.Resources.error;
                    errorArtName.BlinkRate = 0;
                    errorArtName.SetError(artName, "Please fill Art Name");
                    
                }
                if (string.IsNullOrEmpty(categoryBox.Text))
                {
                    categoryBox.BorderColor = Color.Red;
                    // nameError.Clear();
                    errorArtCategory.Icon = Properties.Resources.error;
                    errorArtCategory.BlinkRate = 0;
                    errorArtCategory.SetError(categoryBox, "Please fill Category");
                 
                }
                if (string.IsNullOrEmpty(priceBox.Text))
                {
                    priceBox.BorderColor = Color.Red;
                    //   phoneError.Clear();
                    errorArtPrice.Icon = Properties.Resources.error;
                    errorArtPrice.BlinkRate = 0;
                    errorArtPrice.SetError(priceBox, "Please fill Price");
                  
                }
                
             MessageBox.Show("Please select art & fill all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void SelectArtBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Image";
            dialog.Filter = "Image files (*.png, *.jpg, *jpeg)|*.png;*.jpg;*.jpeg";
            

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ArtPicture.Image = new Bitmap(dialog.FileName);
               
            }
        }

        private void artName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(artName.Text))
            {
                errorArtName.Icon = Properties.Resources.error;
                errorArtName.BlinkRate = 0;
                errorArtName.SetError(artName, "Please fill Art Name");

            }
            else
            {
                errorArtName.Clear();
                artName.BorderColor = Color.White;
            }
        }

        private void priceBox_ValueChanged(object sender, EventArgs e)
        {
            /*string s = "0";
            string c = priceBox.Text;
            if (c.Equals(s))
            {
                errorArtPrice.Icon = Properties.Resources.error;
                errorArtPrice.BlinkRate = 0;
                errorArtPrice.SetError(priceBox, "Please fill Price");

            }
            else
            {
                errorArtPrice.Clear();
                priceBox.BorderColor = Color.White;
            }*/
        }

        private void ArtPicture_Click(object sender, EventArgs e)
        {
            //ArtPicture.Image = Properties.Resources.image;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            /*string s = "0";
            string c = priceBox.Text;*/
            if (string.IsNullOrEmpty(priceBox.Text))
            {
                errorArtPrice.Icon = Properties.Resources.error;
                errorArtPrice.BlinkRate = 0;
                errorArtPrice.SetError(priceBox, "Please fill Price");

            }
            else
            {
                errorArtPrice.Clear();
                priceBox.BorderColor = Color.White;
            }
        }
    }
}
