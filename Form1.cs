using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtisticLounge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutusBtn_Click(object sender, EventArgs e)
        {
            ServiceBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.FlatStyle = FlatStyle.Flat;

            AboutusBtn.FlatStyle = FlatStyle.System;
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            ServiceBtn.FlatStyle = FlatStyle.System;

            ContactBtn.FlatStyle = FlatStyle.Flat;
            AboutusBtn.FlatStyle = FlatStyle.Flat;
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ServiceBtn.FlatStyle = FlatStyle.Flat;

            ContactBtn.FlatStyle = FlatStyle.System;

            AboutusBtn.FlatStyle = FlatStyle.Flat;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
