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
using System.Net.Mail;
using System.Net;

namespace Gallery
{
    public partial class ContactForm : Form
    {
        public bool mainForm { set; get; }
        public ContactForm()
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

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUsForm aboutUsForm = new AboutUsForm();
            if (mainForm == true)
            {
                aboutUsForm.mainForm = true;
            }
            else
            {
                aboutUsForm.mainForm = false;
            }

            aboutUsForm.ShowDialog();
            this.Close();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            ContactFormPanel.Parent = ContactFormBG;
            ContactFormPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            //MessageBoxPanel.Parent = ContactFormBG;
            //MessageBoxPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBox.Text) || !string.IsNullOrEmpty(mailBox.Text) || !string.IsNullOrEmpty(msgBox.Text))
            {
                if (IsValidEmailAddress(mailBox.Text) == true)
                {

                    Message msg = new Message();
                    msg.Email = mailBox.Text.ToString();
                    msg.Name = nameBox.Text.ToString();
                    msg.User_Message = msgBox.Text.ToString();

                    DatabaseHelper.connection.Open();
                    if (DatabaseHelper.SendMsg(msg) == true)
                    {
                        MessageBox.Show("Thanks for contact, Stay with us!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Faild to contact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid email address", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                /*if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(mailBox.Text) || string.IsNullOrEmpty(msgBox.Text))
                {
                    // @Todo - > Error provider
                }
                else
                {
                    if (IsValidEmailAddress(mailBox.Text) == true)
                    {
                        try
                        {

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Check your connection! "+ex.Message, "Connectio Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide a valid email address", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }*/
            }
        }
            public static bool IsValidEmailAddress(string address)
            {
                return new EmailAddressAttribute().IsValid(address);
            }
        }
    } 
