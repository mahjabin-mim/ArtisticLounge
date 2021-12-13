using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2;

namespace Gallery
{

    
    public partial class ArtCard : UserControl
    {
        public Image image { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string art_code { set; get; }

        public Form parentForm { get; set; }

        

        public ArtCard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyNowBtn_Click(object sender, EventArgs e)
        {
            parentForm.Hide();

            BuyForm buyForm = new BuyForm();
            buyForm.art_code = this.art_code;

            buyForm.StartPosition = FormStartPosition.Manual;
            buyForm.Location = parentForm.Location;

            if (parentForm.Size.Height >= buyForm.MinimumSize.Height &&
                parentForm.Size.Width >= buyForm.MaximumSize.Width)
            {
                buyForm.Size = parentForm.Size;
            }


            buyForm.ShowDialog();

            parentForm.Close();
        }

        private void ArtCard_Load(object sender, EventArgs e)
        {
            artImage.Image = this.image;
            arttitle.Text = this.title;
            artPrice.Text = this.price+" Tk.";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
