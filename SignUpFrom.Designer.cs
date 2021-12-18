
namespace Gallery
{
    partial class SignUpFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpFrom));
            this.signupRightPanel = new System.Windows.Forms.Panel();
            this.showPassBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.signupPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.signupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.signUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signUpUnderPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginUnderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.signupPictureBox = new System.Windows.Forms.PictureBox();
            this.signupRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signupRightPanel
            // 
            this.signupRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.signupRightPanel.Controls.Add(this.showPassBtn);
            this.signupRightPanel.Controls.Add(this.signupPass);
            this.signupRightPanel.Controls.Add(this.signupEmail);
            this.signupRightPanel.Controls.Add(this.signupName);
            this.signupRightPanel.Controls.Add(this.signUpBtn);
            this.signupRightPanel.Controls.Add(this.signUpLabel);
            this.signupRightPanel.Controls.Add(this.signUpUnderPanel);
            this.signupRightPanel.Controls.Add(this.loginLabel);
            this.signupRightPanel.Controls.Add(this.loginUnderPanel);
            this.signupRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.signupRightPanel.Location = new System.Drawing.Point(371, 54);
            this.signupRightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupRightPanel.Name = "signupRightPanel";
            this.signupRightPanel.Size = new System.Drawing.Size(422, 421);
            this.signupRightPanel.TabIndex = 18;
            // 
            // showPassBtn
            // 
            this.showPassBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPassBtn.FillColor = System.Drawing.Color.Transparent;
            this.showPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassBtn.Image")));
            this.showPassBtn.ImageRotate = 0F;
            this.showPassBtn.Location = new System.Drawing.Point(326, 270);
            this.showPassBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPassBtn.ShadowDecoration.Parent = this.showPassBtn;
            this.showPassBtn.Size = new System.Drawing.Size(15, 21);
            this.showPassBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassBtn.TabIndex = 19;
            this.showPassBtn.TabStop = false;
            this.showPassBtn.UseTransparentBackground = true;
            this.showPassBtn.Click += new System.EventHandler(this.showPassBtn_Click);
            // 
            // signupPass
            // 
            this.signupPass.BackColor = System.Drawing.Color.Transparent;
            this.signupPass.BorderRadius = 12;
            this.signupPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupPass.DefaultText = "";
            this.signupPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPass.DisabledState.Parent = this.signupPass;
            this.signupPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPass.FocusedState.Parent = this.signupPass;
            this.signupPass.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signupPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupPass.HoverState.Parent = this.signupPass;
            this.signupPass.Location = new System.Drawing.Point(58, 265);
            this.signupPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupPass.Name = "signupPass";
            this.signupPass.PasswordChar = '\0';
            this.signupPass.PlaceholderText = "Password";
            this.signupPass.SelectedText = "";
            this.signupPass.ShadowDecoration.BorderRadius = 12;
            this.signupPass.ShadowDecoration.Enabled = true;
            this.signupPass.ShadowDecoration.Parent = this.signupPass;
            this.signupPass.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupPass.Size = new System.Drawing.Size(290, 31);
            this.signupPass.TabIndex = 17;
            this.signupPass.UseSystemPasswordChar = true;
            // 
            // signupEmail
            // 
            this.signupEmail.BackColor = System.Drawing.Color.Transparent;
            this.signupEmail.BorderRadius = 12;
            this.signupEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupEmail.DefaultText = "";
            this.signupEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmail.DisabledState.Parent = this.signupEmail;
            this.signupEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmail.FocusedState.Parent = this.signupEmail;
            this.signupEmail.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signupEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupEmail.HoverState.Parent = this.signupEmail;
            this.signupEmail.Location = new System.Drawing.Point(58, 216);
            this.signupEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupEmail.Name = "signupEmail";
            this.signupEmail.PasswordChar = '\0';
            this.signupEmail.PlaceholderText = "Email";
            this.signupEmail.SelectedText = "";
            this.signupEmail.ShadowDecoration.BorderRadius = 12;
            this.signupEmail.ShadowDecoration.Enabled = true;
            this.signupEmail.ShadowDecoration.Parent = this.signupEmail;
            this.signupEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupEmail.Size = new System.Drawing.Size(290, 31);
            this.signupEmail.TabIndex = 1;
            // 
            // signupName
            // 
            this.signupName.BackColor = System.Drawing.Color.Transparent;
            this.signupName.BorderRadius = 12;
            this.signupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signupName.DefaultText = "";
            this.signupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupName.DisabledState.Parent = this.signupName;
            this.signupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupName.FocusedState.Parent = this.signupName;
            this.signupName.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signupName.HoverState.Parent = this.signupName;
            this.signupName.Location = new System.Drawing.Point(58, 166);
            this.signupName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupName.Name = "signupName";
            this.signupName.PasswordChar = '\0';
            this.signupName.PlaceholderText = "Name";
            this.signupName.SelectedText = "";
            this.signupName.ShadowDecoration.BorderRadius = 12;
            this.signupName.ShadowDecoration.Enabled = true;
            this.signupName.ShadowDecoration.Parent = this.signupName;
            this.signupName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupName.Size = new System.Drawing.Size(290, 31);
            this.signupName.TabIndex = 0;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpBtn.BorderRadius = 7;
            this.signUpBtn.CheckedState.Parent = this.signUpBtn;
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.CustomImages.Parent = this.signUpBtn;
            this.signUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpBtn.DisabledState.Parent = this.signUpBtn;
            this.signUpBtn.FillColor = System.Drawing.Color.Navy;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.HoverState.Parent = this.signUpBtn;
            this.signUpBtn.Location = new System.Drawing.Point(148, 333);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.ShadowDecoration.BorderRadius = 10;
            this.signUpBtn.ShadowDecoration.Parent = this.signUpBtn;
            this.signUpBtn.Size = new System.Drawing.Size(116, 41);
            this.signUpBtn.TabIndex = 16;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUpLabel.Location = new System.Drawing.Point(219, 83);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(97, 26);
            this.signUpLabel.TabIndex = 10;
            this.signUpLabel.Text = "Sign Up";
            // 
            // signUpUnderPanel
            // 
            this.signUpUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpUnderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUpUnderPanel.Location = new System.Drawing.Point(205, 121);
            this.signUpUnderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpUnderPanel.Name = "signUpUnderPanel";
            this.signUpUnderPanel.Size = new System.Drawing.Size(129, 3);
            this.signUpUnderPanel.TabIndex = 12;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(76, 83);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(70, 26);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // loginUnderPanel
            // 
            this.loginUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginUnderPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginUnderPanel.Location = new System.Drawing.Point(67, 121);
            this.loginUnderPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginUnderPanel.Name = "loginUnderPanel";
            this.loginUnderPanel.Size = new System.Drawing.Size(82, 3);
            this.loginUnderPanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ServicesBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutUsBtn);
            this.panel1.Controls.Add(this.ArtisticLounge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 54);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.BackColor = System.Drawing.Color.White;
            this.ServicesBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ServicesBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServicesBtn.FlatAppearance.BorderSize = 0;
            this.ServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesBtn.ForeColor = System.Drawing.Color.Navy;
            this.ServicesBtn.Location = new System.Drawing.Point(439, 0);
            this.ServicesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(105, 54);
            this.ServicesBtn.TabIndex = 14;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.UseVisualStyleBackColor = false;
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.White;
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.Navy;
            this.ContactBtn.Location = new System.Drawing.Point(334, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(105, 54);
            this.ContactBtn.TabIndex = 11;
            this.ContactBtn.Text = "Contact";
            this.ContactBtn.UseVisualStyleBackColor = false;
            // 
            // AboutUsBtn
            // 
            this.AboutUsBtn.BackColor = System.Drawing.Color.White;
            this.AboutUsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AboutUsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AboutUsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutUsBtn.FlatAppearance.BorderSize = 0;
            this.AboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsBtn.ForeColor = System.Drawing.Color.Navy;
            this.AboutUsBtn.Location = new System.Drawing.Point(229, 0);
            this.AboutUsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(105, 54);
            this.AboutUsBtn.TabIndex = 13;
            this.AboutUsBtn.Text = "About Us";
            this.AboutUsBtn.UseVisualStyleBackColor = false;
            // 
            // ArtisticLounge
            // 
            this.ArtisticLounge.BackColor = System.Drawing.Color.White;
            this.ArtisticLounge.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArtisticLounge.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ArtisticLounge.FlatAppearance.BorderSize = 0;
            this.ArtisticLounge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtisticLounge.Font = new System.Drawing.Font("Segoe Print", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtisticLounge.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ArtisticLounge.Location = new System.Drawing.Point(0, 0);
            this.ArtisticLounge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArtisticLounge.Name = "ArtisticLounge";
            this.ArtisticLounge.Size = new System.Drawing.Size(229, 54);
            this.ArtisticLounge.TabIndex = 12;
            this.ArtisticLounge.Text = "Artistic Lounge";
            this.ArtisticLounge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtisticLounge.UseVisualStyleBackColor = false;
            // 
            // signupPictureBox
            // 
            this.signupPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.signupPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("signupPictureBox.Image")));
            this.signupPictureBox.Location = new System.Drawing.Point(0, 54);
            this.signupPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signupPictureBox.Name = "signupPictureBox";
            this.signupPictureBox.Size = new System.Drawing.Size(793, 421);
            this.signupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signupPictureBox.TabIndex = 17;
            this.signupPictureBox.TabStop = false;
            // 
            // SignUpFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 475);
            this.Controls.Add(this.signupRightPanel);
            this.Controls.Add(this.signupPictureBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(809, 514);
            this.MinimumSize = new System.Drawing.Size(809, 514);
            this.Name = "SignUpFrom";
            this.Text = "SignUpFrom";
            this.Load += new System.EventHandler(this.SignUpFrom_Load);
            this.signupRightPanel.ResumeLayout(false);
            this.signupRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupRightPanel;
        private Guna.UI2.WinForms.Guna2TextBox signupEmail;
        private Guna.UI2.WinForms.Guna2TextBox signupName;
        private Guna.UI2.WinForms.Guna2Button signUpBtn;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Panel signUpUnderPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel loginUnderPanel;
        private System.Windows.Forms.PictureBox signupPictureBox;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox signupPass;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showPassBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ArtisticLounge;
    }
}