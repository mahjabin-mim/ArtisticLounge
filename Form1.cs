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
    public partial class Form1 : Form
    {
        private bool showPass = false;
        public Form1()
        {
           
        
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Parent = pictureBox1;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            // changing sign up color
            signUpLabel.ForeColor = Color.White;
            signUpUnderPanel.BackColor = Color.Transparent;

            //hide signup options
           

            //show login options
            loginEmail.Visible = true;
            loginPass.Visible = true;
            loginBtn.Visible = true;

            //change login color
            loginLabel.ForeColor = Color.FromArgb(1, 0, 0, 192);
            loginUnderPanel.BackColor = Color.Navy;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            SignUpFrom signUpFrom = new SignUpFrom();
            signUpFrom.StartPosition = FormStartPosition.Manual;
            signUpFrom.Location = this.Location;

            signUpFrom.ShowDialog();

            this.Close();

            

            
            
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            
            if (!showPass)
            {
                showPassBtn.Image = Properties.Resources.open;
                showPass = true;  

            }
            else
            {
                showPassBtn.Image = Properties.Resources.hidden__1_;
                showPass = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.StartPosition = FormStartPosition.Manual;
            m.Location = this.Location;
            m.ShowDialog();
            this.Close();
        }
    }
}
