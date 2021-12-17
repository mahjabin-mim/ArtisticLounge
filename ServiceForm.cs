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
    public partial class ServiceForm : Form
    {
        public bool mainForm { set; get; }
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (mainForm == true)
            {
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            ServicePanel.Parent = ServiceFormBG;
            ServicePanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
