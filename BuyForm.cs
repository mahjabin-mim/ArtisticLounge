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
    public partial class BuyForm : Form
    {


        public string art_code { set; get; }

        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            this.ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227); // form collor

            this.buyArtrightPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            DatabaseHelper.connection.Open();

            Art art = DatabaseHelper.GetSpecificArt(this.art_code);

            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(art.Seller);

            artPicture.Image = art.Art_image;
            artNameLabel.Text ="Art name: "+ art.Name;
            categoryLabel.Text = "Catagory: "+art.Catagory;
            artistNameLabel.Text ="Art by: "+user.Name;
            codeLabel.Text = "Product code: "+art.Product_code;
            priceLabel.Text =art.Price+" Tk.";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
       

            mainForm.ShowDialog();

            this.Close();
        }

        private void buyArtleftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm paymentForm = new PaymentForm();
           /* paymentForm.StartPosition = FormStartPosition.Manual;
            paymentForm.Location = this.Location;*/
            //paymentForm.Size = this.Size;

            paymentForm.ShowDialog();
            this.Close();
        }
    }
}
