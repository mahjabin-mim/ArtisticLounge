
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
            this.signupPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutusBtn = new System.Windows.Forms.Button();
            this.signupRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.signupRightPanel.Location = new System.Drawing.Point(699, 100);
            this.signupRightPanel.Name = "signupRightPanel";
            this.signupRightPanel.Size = new System.Drawing.Size(774, 840);
            this.signupRightPanel.TabIndex = 18;
            // 
            // showPassBtn
            // 
            this.showPassBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPassBtn.FillColor = System.Drawing.Color.Transparent;
            this.showPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassBtn.Image")));
            this.showPassBtn.ImageRotate = 0F;
            this.showPassBtn.Location = new System.Drawing.Point(597, 498);
            this.showPassBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPassBtn.ShadowDecoration.Parent = this.showPassBtn;
            this.showPassBtn.Size = new System.Drawing.Size(28, 38);
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
            this.signupPass.Location = new System.Drawing.Point(107, 489);
            this.signupPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupPass.Name = "signupPass";
            this.signupPass.PasswordChar = '\0';
            this.signupPass.PlaceholderText = "Password";
            this.signupPass.SelectedText = "";
            this.signupPass.ShadowDecoration.BorderRadius = 12;
            this.signupPass.ShadowDecoration.Enabled = true;
            this.signupPass.ShadowDecoration.Parent = this.signupPass;
            this.signupPass.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupPass.Size = new System.Drawing.Size(531, 57);
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
            this.signupEmail.Location = new System.Drawing.Point(107, 398);
            this.signupEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupEmail.Name = "signupEmail";
            this.signupEmail.PasswordChar = '\0';
            this.signupEmail.PlaceholderText = "Email";
            this.signupEmail.SelectedText = "";
            this.signupEmail.ShadowDecoration.BorderRadius = 12;
            this.signupEmail.ShadowDecoration.Enabled = true;
            this.signupEmail.ShadowDecoration.Parent = this.signupEmail;
            this.signupEmail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupEmail.Size = new System.Drawing.Size(531, 57);
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
            this.signupName.Location = new System.Drawing.Point(107, 306);
            this.signupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signupName.Name = "signupName";
            this.signupName.PasswordChar = '\0';
            this.signupName.PlaceholderText = "Name";
            this.signupName.SelectedText = "";
            this.signupName.ShadowDecoration.BorderRadius = 12;
            this.signupName.ShadowDecoration.Enabled = true;
            this.signupName.ShadowDecoration.Parent = this.signupName;
            this.signupName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.signupName.Size = new System.Drawing.Size(531, 57);
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
            this.signUpBtn.Location = new System.Drawing.Point(271, 615);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.ShadowDecoration.BorderRadius = 10;
            this.signUpBtn.ShadowDecoration.Parent = this.signUpBtn;
            this.signUpBtn.Size = new System.Drawing.Size(212, 76);
            this.signUpBtn.TabIndex = 16;
            this.signUpBtn.Text = "Sign up";
            // 
            // signUpLabel
            // 
            this.signUpLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUpLabel.Location = new System.Drawing.Point(402, 154);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(160, 44);
            this.signUpLabel.TabIndex = 10;
            this.signUpLabel.Text = "Sign Up";
            // 
            // signUpUnderPanel
            // 
            this.signUpUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signUpUnderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.signUpUnderPanel.Location = new System.Drawing.Point(375, 224);
            this.signUpUnderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.signUpUnderPanel.Name = "signUpUnderPanel";
            this.signUpUnderPanel.Size = new System.Drawing.Size(236, 6);
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
            this.loginLabel.Location = new System.Drawing.Point(139, 154);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(117, 44);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // loginUnderPanel
            // 
            this.loginUnderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginUnderPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginUnderPanel.Location = new System.Drawing.Point(122, 224);
            this.loginUnderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginUnderPanel.Name = "loginUnderPanel";
            this.loginUnderPanel.Size = new System.Drawing.Size(150, 6);
            this.loginUnderPanel.TabIndex = 11;
            // 
            // signupPictureBox
            // 
            this.signupPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.signupPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("signupPictureBox.Image")));
            this.signupPictureBox.Location = new System.Drawing.Point(0, 100);
            this.signupPictureBox.Name = "signupPictureBox";
            this.signupPictureBox.Size = new System.Drawing.Size(1473, 840);
            this.signupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signupPictureBox.TabIndex = 17;
            this.signupPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ServiceBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutusBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 100);
            this.panel1.TabIndex = 16;
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BackColor = System.Drawing.Color.White;
            this.ServiceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ServiceBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServiceBtn.FlatAppearance.BorderSize = 0;
            this.ServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceBtn.ForeColor = System.Drawing.Color.Navy;
            this.ServiceBtn.Location = new System.Drawing.Point(338, 0);
            this.ServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(169, 100);
            this.ServiceBtn.TabIndex = 0;
            this.ServiceBtn.Text = "Services";
            this.ServiceBtn.UseVisualStyleBackColor = false;
            this.ServiceBtn.Click += new System.EventHandler(this.ServiceBtn_Click);
            // 
            // ContactBtn
            // 
            this.ContactBtn.BackColor = System.Drawing.Color.White;
            this.ContactBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.Navy;
            this.ContactBtn.Location = new System.Drawing.Point(169, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(169, 100);
            this.ContactBtn.TabIndex = 2;
            this.ContactBtn.Text = "Contact";
            this.ContactBtn.UseVisualStyleBackColor = false;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // AboutusBtn
            // 
            this.AboutusBtn.BackColor = System.Drawing.Color.White;
            this.AboutusBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AboutusBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutusBtn.FlatAppearance.BorderSize = 0;
            this.AboutusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutusBtn.ForeColor = System.Drawing.Color.Navy;
            this.AboutusBtn.Location = new System.Drawing.Point(0, 0);
            this.AboutusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AboutusBtn.Name = "AboutusBtn";
            this.AboutusBtn.Size = new System.Drawing.Size(169, 100);
            this.AboutusBtn.TabIndex = 1;
            this.AboutusBtn.Text = "About Us";
            this.AboutusBtn.UseVisualStyleBackColor = false;
            this.AboutusBtn.Click += new System.EventHandler(this.AboutusBtn_Click);
            // 
            // SignUpFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 940);
            this.Controls.Add(this.signupRightPanel);
            this.Controls.Add(this.signupPictureBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpFrom";
            this.Text = "SignUpFrom";
            this.Load += new System.EventHandler(this.SignUpFrom_Load);
            this.signupRightPanel.ResumeLayout(false);
            this.signupRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button ServiceBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutusBtn;
        private Guna.UI2.WinForms.Guna2TextBox signupPass;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showPassBtn;
    }
}