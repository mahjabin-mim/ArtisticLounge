using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

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

            LoadData();
        }

        private void LoadData()
        {
            DatabaseHelper.connection.Open();

            Art art = DatabaseHelper.GetSpecificArt(this.art_code);

            DatabaseHelper.connection.Open();

            User user = DatabaseHelper.GetUser(art.Seller);

            artPicture.Image = art.Art_image;
            artNameLabel.Text = art.Name;
            categoryLabel.Text = "Catagory: " + art.Catagory;
            artistNameLabel.Text = "Art by: " + user.Name;
            codeLabel.Text = "Product code: " + art.Product_code;
            priceLabel.Text = art.Price + " Tk.";

            if (art.Seller.Trim().Equals(User.Email.Trim()))
            {
                proceedBtn.Enabled = false;
            }
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
            bool procced = true;
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailTextBox.BorderColor = Color.Red;
              //  emailError.Clear();
                emailError.Icon = Properties.Resources.error;
                emailError.BlinkRate = 0;
                emailError.SetError(emailTextBox, "Please give email");
                procced = false;
            }
            if (IsValidEmailAddress(emailTextBox.Text) == false)
            {
                emailTextBox.BorderColor = Color.Red;
                //  emailError.Clear();
                emailError.Icon = Properties.Resources.error;
                emailError.BlinkRate = 0;
                emailError.SetError(emailTextBox, "Please give a valid email address");
                procced = false;
            }
            if(string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameTextBox.BorderColor = Color.Red;
               // nameError.Clear();
                nameError.Icon = Properties.Resources.error;
                nameError.BlinkRate = 0;
                nameError.SetError(nameTextBox, "Please give name");
                procced = false;
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                phoneTextBox.BorderColor = Color.Red;
             //   phoneError.Clear();
                phoneError.Icon = Properties.Resources.error;
                phoneError.BlinkRate = 0;
                phoneError.SetError(phoneTextBox, "Please give number");
                procced = false;

            }
           if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                addressTextBox.BorderColor = Color.Red;
              //  locationError.Clear();
                locationError.Icon = Properties.Resources.error;
                locationError.BlinkRate = 0;
                locationError.SetError(addressTextBox, "Please give location");
                procced = false;
            }
            if(procced == true)
            {
                emailTextBox.BorderColor = Color.White;
                nameTextBox.BorderColor = Color.White;
                phoneTextBox.BorderColor = Color.White;
                addressTextBox.BorderColor = Color.White;

                nameError.Clear(); emailError.Clear(); phoneError.Clear(); locationError.Clear();

                this.Hide();
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.art_code = this.art_code;

                paymentForm.ShowDialog();
                this.Close();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameError.Icon = Properties.Resources.error;
                nameError.BlinkRate = 0;
                nameError.SetError(nameTextBox, "Please fill Price");

            }
            else
            {
                nameError.Clear();
                nameTextBox.BorderColor = Color.White;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                emailError.Icon = Properties.Resources.error;
                emailError.BlinkRate = 0;
                emailError.SetError(nameTextBox, "Please fill Price");

            }
            else
            {
                emailError.Clear();
                nameTextBox.BorderColor = Color.White;
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                phoneError.Icon = Properties.Resources.error;
                phoneError.BlinkRate = 0;
                phoneError.SetError(phoneTextBox, "Please fill Price");

            }
            else
            {
                phoneError.Clear();
                phoneTextBox.BorderColor = Color.White;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                locationError.Icon = Properties.Resources.error;
                locationError.BlinkRate = 0;
                locationError.SetError(addressTextBox, "Please fill Price");

            }
            else
            {
                locationError.Clear();
                addressTextBox.BorderColor = Color.White;
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        public static bool IsValidEmailAddress(string address)
        {
            return new EmailAddressAttribute().IsValid(address);
        }
    }
}
