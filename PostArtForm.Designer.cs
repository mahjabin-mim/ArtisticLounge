﻿namespace Gallery
{
    partial class PostArtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostArtForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToMainForm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.PostPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SelectArtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ArtPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PostPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BackToMainForm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ServicesBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutUsBtn);
            this.panel1.Controls.Add(this.ArtisticLounge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 67);
            this.panel1.TabIndex = 18;
            // 
            // BackToMainForm
            // 
            this.BackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("BackToMainForm.Image")));
            this.BackToMainForm.ImageRotate = 0F;
            this.BackToMainForm.Location = new System.Drawing.Point(1180, 0);
            this.BackToMainForm.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.BackToMainForm.Name = "BackToMainForm";
            this.BackToMainForm.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.BackToMainForm.ShadowDecoration.Parent = this.BackToMainForm;
            this.BackToMainForm.Size = new System.Drawing.Size(73, 67);
            this.BackToMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackToMainForm.TabIndex = 20;
            this.BackToMainForm.TabStop = false;
            this.BackToMainForm.Click += new System.EventHandler(this.BackToMainForm_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 67);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
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
            this.ServicesBtn.Location = new System.Drawing.Point(585, 0);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(140, 67);
            this.ServicesBtn.TabIndex = 9;
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
            this.ContactBtn.Location = new System.Drawing.Point(445, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(140, 67);
            this.ContactBtn.TabIndex = 6;
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
            this.AboutUsBtn.Location = new System.Drawing.Point(305, 0);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(140, 67);
            this.AboutUsBtn.TabIndex = 8;
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
            this.ArtisticLounge.Name = "ArtisticLounge";
            this.ArtisticLounge.Size = new System.Drawing.Size(305, 67);
            this.ArtisticLounge.TabIndex = 7;
            this.ArtisticLounge.Text = "Artistic Lounge";
            this.ArtisticLounge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtisticLounge.UseVisualStyleBackColor = false;
            // 
            // PostPanel
            // 
            this.PostPanel.BackColor = System.Drawing.Color.Transparent;
            this.PostPanel.Controls.Add(this.panel4);
            this.PostPanel.Controls.Add(this.panel3);
            this.PostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostPanel.Location = new System.Drawing.Point(0, 67);
            this.PostPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostPanel.Name = "PostPanel";
            this.PostPanel.Size = new System.Drawing.Size(1253, 587);
            this.PostPanel.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2Button1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.guna2NumericUpDown1);
            this.panel4.Controls.Add(this.guna2ComboBox1);
            this.panel4.Controls.Add(this.emailTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(602, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 587);
            this.panel4.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(319, 494);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(218, 49);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(134, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Art Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(134, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Art Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(134, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Art Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.Navy;
            this.guna2NumericUpDown1.BorderRadius = 7;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(139, 341);
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(175, 37);
            this.guna2NumericUpDown1.TabIndex = 38;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Navy;
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Navy;
            this.guna2ComboBox1.BorderRadius = 7;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Navy;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Fine Art",
            "Vector Art",
            "Composition ",
            "Other"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(139, 263);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(246, 36);
            this.guna2ComboBox1.TabIndex = 37;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BorderColor = System.Drawing.Color.Navy;
            this.emailTextBox.BorderRadius = 7;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(143, 171);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(389, 40);
            this.emailTextBox.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SelectArtBtn);
            this.panel3.Controls.Add(this.ArtPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 587);
            this.panel3.TabIndex = 0;
            // 
            // SelectArtBtn
            // 
            this.SelectArtBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectArtBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SelectArtBtn.BorderRadius = 10;
            this.SelectArtBtn.BorderThickness = 2;
            this.SelectArtBtn.CheckedState.Parent = this.SelectArtBtn;
            this.SelectArtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectArtBtn.CustomImages.Parent = this.SelectArtBtn;
            this.SelectArtBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectArtBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectArtBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectArtBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectArtBtn.DisabledState.Parent = this.SelectArtBtn;
            this.SelectArtBtn.FillColor = System.Drawing.Color.Navy;
            this.SelectArtBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectArtBtn.ForeColor = System.Drawing.Color.White;
            this.SelectArtBtn.HoverState.Parent = this.SelectArtBtn;
            this.SelectArtBtn.Location = new System.Drawing.Point(233, 423);
            this.SelectArtBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectArtBtn.Name = "SelectArtBtn";
            this.SelectArtBtn.ShadowDecoration.Parent = this.SelectArtBtn;
            this.SelectArtBtn.Size = new System.Drawing.Size(173, 45);
            this.SelectArtBtn.TabIndex = 32;
            this.SelectArtBtn.Text = "Select Art";
            // 
            // ArtPicture
            // 
            this.ArtPicture.Image = ((System.Drawing.Image)(resources.GetObject("ArtPicture.Image")));
            this.ArtPicture.Location = new System.Drawing.Point(26, 47);
            this.ArtPicture.Name = "ArtPicture";
            this.ArtPicture.Size = new System.Drawing.Size(576, 355);
            this.ArtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArtPicture.TabIndex = 1;
            this.ArtPicture.TabStop = false;
            // 
            // PostArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 654);
            this.Controls.Add(this.PostPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1271, 712);
            this.MinimumSize = new System.Drawing.Size(1271, 694);
            this.Name = "PostArtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostArtForm";
            this.Load += new System.EventHandler(this.PostArtForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PostPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArtPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ArtisticLounge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PostPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ArtPicture;
        private Guna.UI2.WinForms.Guna2Button SelectArtBtn;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox BackToMainForm;
    }
}