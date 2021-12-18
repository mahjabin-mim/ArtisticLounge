namespace Gallery
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMainForm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.AboutUsPanel = new System.Windows.Forms.Panel();
            this.AboutUsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutUsFormBG = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AboutUsPanel.SuspendLayout();
            this.AboutUsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutUsFormBG)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 100);
            this.panel1.TabIndex = 16;
            // 
            // BackToMainForm
            // 
            this.BackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("BackToMainForm.Image")));
            this.BackToMainForm.ImageRotate = 0F;
            this.BackToMainForm.Location = new System.Drawing.Point(1344, 0);
            this.BackToMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.BackToMainForm.Name = "BackToMainForm";
            this.BackToMainForm.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.BackToMainForm.ShadowDecoration.Parent = this.BackToMainForm;
            this.BackToMainForm.Size = new System.Drawing.Size(101, 100);
            this.BackToMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackToMainForm.TabIndex = 15;
            this.BackToMainForm.TabStop = false;
            this.BackToMainForm.Click += new System.EventHandler(this.BackToMainForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 81);
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
            this.ServicesBtn.Location = new System.Drawing.Point(804, 0);
            this.ServicesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(192, 100);
            this.ServicesBtn.TabIndex = 14;
            this.ServicesBtn.Text = "Services";
            this.ServicesBtn.UseVisualStyleBackColor = false;
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesBtn_Click);
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
            this.ContactBtn.Location = new System.Drawing.Point(612, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(192, 100);
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
            this.AboutUsBtn.Location = new System.Drawing.Point(420, 0);
            this.AboutUsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(192, 100);
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
            this.ArtisticLounge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArtisticLounge.Name = "ArtisticLounge";
            this.ArtisticLounge.Size = new System.Drawing.Size(420, 100);
            this.ArtisticLounge.TabIndex = 12;
            this.ArtisticLounge.Text = "Artistic Lounge";
            this.ArtisticLounge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtisticLounge.UseVisualStyleBackColor = false;
            // 
            // AboutUsPanel
            // 
            this.AboutUsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AboutUsPanel.Controls.Add(this.AboutUsGroupBox);
            this.AboutUsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutUsPanel.Location = new System.Drawing.Point(0, 100);
            this.AboutUsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsPanel.Name = "AboutUsPanel";
            this.AboutUsPanel.Size = new System.Drawing.Size(1445, 751);
            this.AboutUsPanel.TabIndex = 18;
            // 
            // AboutUsGroupBox
            // 
            this.AboutUsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsGroupBox.Controls.Add(this.label1);
            this.AboutUsGroupBox.Font = new System.Drawing.Font("Lucida Console", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsGroupBox.ForeColor = System.Drawing.Color.White;
            this.AboutUsGroupBox.Location = new System.Drawing.Point(682, 153);
            this.AboutUsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsGroupBox.Name = "AboutUsGroupBox";
            this.AboutUsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsGroupBox.Size = new System.Drawing.Size(712, 508);
            this.AboutUsGroupBox.TabIndex = 0;
            this.AboutUsGroupBox.TabStop = false;
            this.AboutUsGroupBox.Text = "About Us";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 446);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // AboutUsFormBG
            // 
            this.AboutUsFormBG.Cursor = System.Windows.Forms.Cursors.Default;
            this.AboutUsFormBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutUsFormBG.Image = ((System.Drawing.Image)(resources.GetObject("AboutUsFormBG.Image")));
            this.AboutUsFormBG.Location = new System.Drawing.Point(0, 100);
            this.AboutUsFormBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsFormBG.Name = "AboutUsFormBG";
            this.AboutUsFormBG.Size = new System.Drawing.Size(1445, 751);
            this.AboutUsFormBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AboutUsFormBG.TabIndex = 17;
            this.AboutUsFormBG.TabStop = false;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 851);
            this.Controls.Add(this.AboutUsPanel);
            this.Controls.Add(this.AboutUsFormBG);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1469, 915);
            this.MinimumSize = new System.Drawing.Size(1469, 915);
            this.Name = "AboutUsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutUsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutUsForm_FormClosed);
            this.Load += new System.EventHandler(this.AboutUsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AboutUsPanel.ResumeLayout(false);
            this.AboutUsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutUsFormBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox AboutUsFormBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ArtisticLounge;
        private System.Windows.Forms.Panel AboutUsPanel;
        private System.Windows.Forms.GroupBox AboutUsGroupBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox BackToMainForm;
    }
}