namespace Gallery
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.navDrawerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PostBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MainFormPanelBg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.navDrawerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.ServicesBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutUsBtn);
            this.panel1.Controls.Add(this.ArtisticLounge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 100);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = global::Gallery.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1474, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
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
            this.ServicesBtn.Location = new System.Drawing.Point(805, 0);
            this.ServicesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(193, 100);
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
            this.ContactBtn.Location = new System.Drawing.Point(612, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(193, 100);
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
            this.AboutUsBtn.Location = new System.Drawing.Point(419, 0);
            this.AboutUsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(193, 100);
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
            this.ArtisticLounge.Margin = new System.Windows.Forms.Padding(4);
            this.ArtisticLounge.Name = "ArtisticLounge";
            this.ArtisticLounge.Size = new System.Drawing.Size(419, 100);
            this.ArtisticLounge.TabIndex = 7;
            this.ArtisticLounge.Text = "Artistic Lounge";
            this.ArtisticLounge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtisticLounge.UseVisualStyleBackColor = false;
            // 
            // navDrawerPanel
            // 
            this.navDrawerPanel.AutoScroll = true;
            this.navDrawerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.navDrawerPanel.Controls.Add(this.PostBtn);
            this.navDrawerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDrawerPanel.Location = new System.Drawing.Point(0, 100);
            this.navDrawerPanel.Name = "navDrawerPanel";
            this.navDrawerPanel.ShadowDecoration.Parent = this.navDrawerPanel;
            this.navDrawerPanel.Size = new System.Drawing.Size(415, 898);
            this.navDrawerPanel.TabIndex = 18;
            // 
            // PostBtn
            // 
            this.PostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PostBtn.AutoRoundedCorners = true;
            this.PostBtn.BorderRadius = 38;
            this.PostBtn.CheckedState.Parent = this.PostBtn;
            this.PostBtn.CustomImages.Parent = this.PostBtn;
            this.PostBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PostBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PostBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PostBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PostBtn.DisabledState.Parent = this.PostBtn;
            this.PostBtn.FillColor = System.Drawing.Color.Navy;
            this.PostBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold);
            this.PostBtn.ForeColor = System.Drawing.Color.White;
            this.PostBtn.HoverState.Parent = this.PostBtn;
            this.PostBtn.Image = ((System.Drawing.Image)(resources.GetObject("PostBtn.Image")));
            this.PostBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PostBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.PostBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.PostBtn.Location = new System.Drawing.Point(53, 759);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Padding = new System.Windows.Forms.Padding(2, 2, 12, 2);
            this.PostBtn.ShadowDecoration.Parent = this.PostBtn;
            this.PostBtn.Size = new System.Drawing.Size(294, 79);
            this.PostBtn.TabIndex = 0;
            this.PostBtn.Text = "Post an Art";
            this.PostBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainFormPanelBg
            // 
            this.MainFormPanelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormPanelBg.Image = ((System.Drawing.Image)(resources.GetObject("MainFormPanelBg.Image")));
            this.MainFormPanelBg.ImageRotate = 0F;
            this.MainFormPanelBg.Location = new System.Drawing.Point(0, 0);
            this.MainFormPanelBg.Name = "MainFormPanelBg";
            this.MainFormPanelBg.ShadowDecoration.Parent = this.MainFormPanelBg;
            this.MainFormPanelBg.Size = new System.Drawing.Size(1574, 998);
            this.MainFormPanelBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainFormPanelBg.TabIndex = 0;
            this.MainFormPanelBg.TabStop = false;
            this.MainFormPanelBg.Click += new System.EventHandler(this.guna2PictureBox1_Click_1);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(415, 100);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.mainPanel.Size = new System.Drawing.Size(1159, 898);
            this.mainPanel.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 998);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navDrawerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainFormPanelBg);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.navDrawerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox MainFormPanelBg;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel navDrawerPanel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button ServicesBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ArtisticLounge;
        private Guna.UI2.WinForms.Guna2Button PostBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}