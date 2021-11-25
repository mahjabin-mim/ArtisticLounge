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
    public partial class SignUpFrom : Form
    {
        public SignUpFrom()
        {
            InitializeComponent();

            
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;

            form1.ShowDialog();
            this.Close();
        }

        private void SignUpFrom_Load(object sender, EventArgs e)
        {
            signupRightPanel.Parent = signupPictureBox;
        }
    }
}
