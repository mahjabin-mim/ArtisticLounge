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
    public partial class PaymentForm : Form
    {
        public string art_code { set; get; }
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

       

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227);

            paymentPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            backBtn.Cursor = Cursors.Hand;
            confirmBtn.Cursor = Cursors.Hand;

            LoadData();
        }

        private void LoadData()
        {
            DatabaseHelper.connection.Open();

            Art art = DatabaseHelper.GetSpecificArt(this.art_code);

            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(art.Seller);

            this.artPicture.Image = art.Art_image;
            this.artNameLabel.Text = art.Name;
            this.categoryLabel.Text = "Catagory: " + art.Catagory;
            this.artistNameLabel.Text = "Art by: " + user.Name;
            this.codeLabel.Text = "Product code: " + art.Product_code;
            this.priceLabel.Text = art.Price + " Tk.";
            this.subTotal.Text = art.Price + ".00";
            this.shipping.Text = "49.00";
            this.extraCharge.Text = "0.00";

            string total = (Convert.ToDouble(this.subTotal.Text) + Convert.ToDouble(this.shipping.Text) + Convert.ToDouble(extraCharge.Text)).ToString();
            this.totalPrice.Text = total + ".00 Tk.";

        }


      

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (cardRb.Checked == true || mobileRb.Checked == true)
            {

                DatabaseHelper.connection.Open();

                if (DatabaseHelper.UpdateArt(this.art_code) == true)
                {
                    this.Hide();
                    ThankYouForm thankYou = new ThankYouForm();
                    thankYou.ShowDialog();
                    this.Close();
                }
                else
                {
                   MessageBox.Show("Purchase error!", "Purchase", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }

                
            }
            else
            {
                MessageBox.Show("Pleaase select a payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            BuyForm buyForm = new BuyForm();
            buyForm.art_code = this.art_code;


            buyForm.ShowDialog();

            this.Close();
        }

        private void sendGiftCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sendGiftCheck.Checked == true)
            {
                extraCharge.Text = "20.00";
                string total = (Convert.ToDouble(this.subTotal.Text) + Convert.ToDouble(this.shipping.Text) + Convert.ToDouble(extraCharge.Text)).ToString();
                this.totalPrice.Text = total + ".00";
            }
            else
            {
                extraCharge.Text = "0.00";
                string total = (Convert.ToDouble(this.subTotal.Text) + Convert.ToDouble(this.shipping.Text) + Convert.ToDouble(extraCharge.Text)).ToString();
                this.totalPrice.Text = total + ".00";
            }
        }

       
    }
}
