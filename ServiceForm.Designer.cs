namespace Gallery
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.ServiceFormBG = new System.Windows.Forms.PictureBox();
            this.ServicePanel = new System.Windows.Forms.Panel();
            this.ServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMainForm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceFormBG)).BeginInit();
            this.ServicePanel.SuspendLayout();
            this.ServiceGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceFormBG
            // 
            this.ServiceFormBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceFormBG.Image = ((System.Drawing.Image)(resources.GetObject("ServiceFormBG.Image")));
            this.ServiceFormBG.Location = new System.Drawing.Point(0, 0);
            this.ServiceFormBG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceFormBG.Name = "ServiceFormBG";
            this.ServiceFormBG.Size = new System.Drawing.Size(796, 486);
            this.ServiceFormBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServiceFormBG.TabIndex = 1;
            this.ServiceFormBG.TabStop = false;
            // 
            // ServicePanel
            // 
            this.ServicePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServicePanel.Controls.Add(this.ServiceGroupBox);
            this.ServicePanel.Controls.Add(this.panel1);
            this.ServicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicePanel.Location = new System.Drawing.Point(0, 0);
            this.ServicePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(796, 486);
            this.ServicePanel.TabIndex = 2;
            // 
            // ServiceGroupBox
            // 
            this.ServiceGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ServiceGroupBox.Controls.Add(this.label1);
            this.ServiceGroupBox.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceGroupBox.ForeColor = System.Drawing.Color.White;
            this.ServiceGroupBox.Location = new System.Drawing.Point(398, 158);
            this.ServiceGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceGroupBox.Name = "ServiceGroupBox";
            this.ServiceGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceGroupBox.Size = new System.Drawing.Size(362, 258);
            this.ServiceGroupBox.TabIndex = 20;
            this.ServiceGroupBox.TabStop = false;
            this.ServiceGroupBox.Text = "Delivery Service";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 205);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BackToMainForm);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ServicesBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutUsBtn);
            this.panel1.Controls.Add(this.ArtisticLounge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 54);
            this.panel1.TabIndex = 19;
            // 
            // BackToMainForm
            // 
            this.BackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("BackToMainForm.Image")));
            this.BackToMainForm.ImageRotate = 0F;
            this.BackToMainForm.Location = new System.Drawing.Point(741, 0);
            this.BackToMainForm.Margin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.BackToMainForm.Name = "BackToMainForm";
            this.BackToMainForm.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.BackToMainForm.ShadowDecoration.Parent = this.BackToMainForm;
            this.BackToMainForm.Size = new System.Drawing.Size(55, 54);
            this.BackToMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackToMainForm.TabIndex = 15;
            this.BackToMainForm.TabStop = false;
            this.BackToMainForm.Click += new System.EventHandler(this.BackToMainForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
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
            this.AboutUsBtn.Click += new System.EventHandler(this.AboutUsBtn_Click);
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
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 486);
            this.Controls.Add(this.ServicePanel);
            this.Controls.Add(this.ServiceFormBG);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 525);
            this.MinimumSize = new System.Drawing.Size(812, 525);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceFormBG)).EndInit();
            this.ServicePanel.ResumeLayout(false);
            this.ServiceGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ServiceFormBG;
        private System.Windows.Forms.Panel ServicePanel;
        private System.Windows.Forms.GroupBox ServiceGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox BackToMainForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ArtisticLounge;
    }
}