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
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            ArtisticLounge.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.BackColor = Color.FromArgb(138, 175, 227);

            paymentPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            BuyForm buyForm = new BuyForm();
     /*       buyForm.StartPosition = FormStartPosition.Manual;
            buyForm.Location = this.Location;*/


            buyForm.ShowDialog();

            this.Close();
        }
    }
}
