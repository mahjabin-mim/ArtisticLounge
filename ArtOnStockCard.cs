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
    public partial class ArtOnStockCard : UserControl
    {
        public Image image { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string art_code { set; get; }

        public ArtOnStockCard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DatabaseHelper.connection.Open();

            if (DatabaseHelper.DeleteArt(art_code) == true)
            {
                MessageBox.Show("Art Delete", "Delete", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Delete error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArtOnStockCard_Load_1(object sender, EventArgs e)
        {
            ArtImage.Image = this.image;
            ArtName.Text = this.title;
            ArtPrice.Text = this.price;
        }
    }
}
