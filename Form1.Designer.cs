﻿
namespace Gallery
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signUpUnderPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginUnderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutusBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.loginPass);
            this.panel2.Controls.Add(this.loginEmail);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.signUpLabel);
            this.panel2.Controls.Add(this.signUpUnderPanel);
            this.panel2.Controls.Add(this.loginLabel);
            this.panel2.Controls.Add(this.loginUnderPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(508, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 560);
            this.panel2.TabIndex = 15;
            // 
            // loginPass
            // 
            this.loginPass.BorderRadius = 12;
            this.loginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPass.DefaultText = "";
            this.loginPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPass.DisabledState.Parent = this.loginPass;
            this.loginPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPass.FocusedState.Parent = this.loginPass;
            this.loginPass.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPass.HoverState.Parent = this.loginPass;
            this.loginPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginPass.IconLeft")));
            this.loginPass.IconLeftSize = new System.Drawing.Size(22, 22);
            this.loginPass.Location = new System.Drawing.Point(78, 263);
            this.loginPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPass.Name = "loginPass";
            this.loginPass.Padding = new System.Windows.Forms.Padding(10);
            this.loginPass.PasswordChar = '\0';
            this.loginPass.PlaceholderText = "Password";
            this.loginPass.SelectedText = "";
            this.loginPass.ShadowDecoration.BorderRadius = 12;
            this.loginPass.ShadowDecoration.Enabled = true;
            this.loginPass.ShadowDecoration.Parent = this.loginPass;
            this.loginPass.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.loginPass.Size = new System.Drawing.Size(386, 38);
            this.loginPass.TabIndex = 1;
            this.loginPass.UseSystemPasswordChar = true;
            // 
            // loginEmail
            // 
            this.loginEmail.BorderRadius = 12;
            this.loginEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginEmail.DefaultText = "";
            this.loginEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginEmail.DisabledState.Parent = this.loginEmail;
            this.loginEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginEmail.FocusedState.Parent = this.loginEmail;
            this.loginEmail.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginEmail.HoverState.Parent = this.loginEmail;
            this.loginEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginEmail.IconLeft")));
            this.loginEmail.Location = new System.Drawing.Point(78, 204);
            this.loginEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Padding = new System.Windows.Forms.Padding(10);
            this.loginEmail.PasswordChar = '\0';
            this.loginEmail.PlaceholderText = "Email";
            this.loginEmail.SelectedText = "";
            this.loginEmail.ShadowDecoration.BorderRadius = 12;
            this.loginEmail.ShadowDecoration.Enabled = true;
            this.loginEmail.ShadowDecoration.Parent = this.loginEmail;
            this.loginEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.loginEmail.Size = new System.Drawing.Size(386, 38);
            this.loginEmail.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderRadius = 7;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginBtn.DisabledState.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.Navy;
            this.loginBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(197, 337);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.BorderRadius = 10;
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(154, 51);
            this.loginBtn.TabIndex = 16;
            this.loginBtn.Text = "Login";
            // 
            // signUpLabel
            // 
            this.signUpLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.White;
            this.signUpLabel.Location = new System.Drawing.Point(292, 103);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(118, 38);
            this.signUpLabel.TabIndex = 10;
            this.signUpLabel.Text = "Sign Up";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // signUpUnderPanel
            // 
            this.signUpUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpUnderPanel.BackColor = System.Drawing.Color.Transparent;
            this.signUpUnderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUpUnderPanel.Location = new System.Drawing.Point(273, 149);
            this.signUpUnderPanel.Name = "signUpUnderPanel";
            this.signUpUnderPanel.Size = new System.Drawing.Size(172, 4);
            this.signUpUnderPanel.TabIndex = 12;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginLabel.Location = new System.Drawing.Point(101, 103);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(82, 38);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // loginUnderPanel
            // 
            this.loginUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginUnderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginUnderPanel.Location = new System.Drawing.Point(89, 149);
            this.loginUnderPanel.Name = "loginUnderPanel";
            this.loginUnderPanel.Size = new System.Drawing.Size(109, 4);
            this.loginUnderPanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ServiceBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutusBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 67);
            this.panel1.TabIndex = 13;
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ServiceBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiceBtn.FlatAppearance.BorderSize = 0;
            this.ServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceBtn.ForeColor = System.Drawing.Color.White;
            this.ServiceBtn.Location = new System.Drawing.Point(246, 0);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(123, 67);
            this.ServiceBtn.TabIndex = 0;
            this.ServiceBtn.Text = "Services";
            this.ServiceBtn.UseVisualStyleBackColor = false;
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.White;
            this.ContactBtn.Location = new System.Drawing.Point(123, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(123, 67);
            this.ContactBtn.TabIndex = 2;
            this.ContactBtn.Text = "Contact";
            this.ContactBtn.UseVisualStyleBackColor = false;
            // 
            // AboutusBtn
            // 
            this.AboutusBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutusBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AboutusBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutusBtn.FlatAppearance.BorderSize = 0;
            this.AboutusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutusBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutusBtn.ForeColor = System.Drawing.Color.White;
            this.AboutusBtn.Location = new System.Drawing.Point(0, 0);
            this.AboutusBtn.Name = "AboutusBtn";
            this.AboutusBtn.Size = new System.Drawing.Size(123, 67);
            this.AboutusBtn.TabIndex = 1;
            this.AboutusBtn.Text = "About Us";
            this.AboutusBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox loginPass;
        private Guna.UI2.WinForms.Guna2TextBox loginEmail;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Panel signUpUnderPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel loginUnderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ServiceBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutusBtn;
    }
}

