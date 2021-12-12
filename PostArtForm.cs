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
           

            mainForm.ShowDialog();

            this.Close();
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(artName.Text) && categoryBox.SelectedIndex > -1)
            {
                DatabaseHelper.connection.Open();
                Art art = new Art();
                art.Name = artName.Text;
                art.Catagory = categoryBox.Items[categoryBox.SelectedIndex].ToString();
                art.Price = priceBox.Value.ToString();
                art.Art_image = ArtPicture.Image;
                art.Seller = User.Email;
                art.Status = "Available"; // this will be changed to pending

                if (DatabaseHelper.PostArt(art) == true)
                {
                    MessageBox.Show("Art posted", "Post Art", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error posint art", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                }
            }
            else
            {
                MessageBox.Show("Please select all the items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void SelectArtBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Image";
            dialog.Filter = "IMAGE FILE (*.*) | *.*";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ArtPicture.Image = new Bitmap(dialog.FileName);
               
            }
        }
    }
}
