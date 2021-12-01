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
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            this.ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227); // form collor

            this.buyArtrightPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;

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
            paymentForm.StartPosition = FormStartPosition.Manual;
            paymentForm.Location = this.Location;
            //paymentForm.Size = this.Size;

            paymentForm.ShowDialog();
            this.Close();
        }
    }
}
