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
            this.navDrawerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dropDownPanel = new System.Windows.Forms.Panel();
            this.otherBtn = new Guna.UI2.WinForms.Guna2Button();
            this.compositionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.vectorBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fineArt = new Guna.UI2.WinForms.Guna2Button();
            this.categoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MainFormPanelBg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dropDonwTimer = new System.Windows.Forms.Timer(this.components);
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.AboutUsBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.ServicesBtn = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navDrawerPanel.SuspendLayout();
            this.dropDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navDrawerPanel
            // 
            this.navDrawerPanel.AutoScroll = true;
            this.navDrawerPanel.BackColor = System.Drawing.Color.White;
            this.navDrawerPanel.Controls.Add(this.logoutBtn);
            this.navDrawerPanel.Controls.Add(this.dropDownPanel);
            this.navDrawerPanel.Controls.Add(this.homeBtn);
            this.navDrawerPanel.Controls.Add(this.panel2);
            this.navDrawerPanel.Controls.Add(this.PostBtn);
            this.navDrawerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDrawerPanel.Location = new System.Drawing.Point(0, 67);
            this.navDrawerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.navDrawerPanel.Name = "navDrawerPanel";
            this.navDrawerPanel.ShadowDecoration.Parent = this.navDrawerPanel;
            this.navDrawerPanel.Size = new System.Drawing.Size(302, 598);
            this.navDrawerPanel.TabIndex = 18;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.CheckedState.Parent = this.logoutBtn;
            this.logoutBtn.CustomImages.Parent = this.logoutBtn;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.DisabledState.Parent = this.logoutBtn;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.HoverState.Parent = this.logoutBtn;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.logoutBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.logoutBtn.Location = new System.Drawing.Point(0, 346);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.ShadowDecoration.Parent = this.logoutBtn;
            this.logoutBtn.Size = new System.Drawing.Size(302, 45);
            this.logoutBtn.TabIndex = 20;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dropDownPanel
            // 
            this.dropDownPanel.BackColor = System.Drawing.Color.Transparent;
            this.dropDownPanel.Controls.Add(this.otherBtn);
            this.dropDownPanel.Controls.Add(this.compositionBtn);
            this.dropDownPanel.Controls.Add(this.vectorBtn);
            this.dropDownPanel.Controls.Add(this.fineArt);
            this.dropDownPanel.Controls.Add(this.categoryBtn);
            this.dropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDownPanel.Location = new System.Drawing.Point(0, 118);
            this.dropDownPanel.MaximumSize = new System.Drawing.Size(302, 228);
            this.dropDownPanel.MinimumSize = new System.Drawing.Size(302, 44);
            this.dropDownPanel.Name = "dropDownPanel";
            this.dropDownPanel.Size = new System.Drawing.Size(302, 228);
            this.dropDownPanel.TabIndex = 17;
            // 
            // otherBtn
            // 
            this.otherBtn.BackColor = System.Drawing.Color.Transparent;
            this.otherBtn.CheckedState.Parent = this.otherBtn;
            this.otherBtn.CustomImages.Parent = this.otherBtn;
            this.otherBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.otherBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.otherBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.otherBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.otherBtn.DisabledState.Parent = this.otherBtn;
            this.otherBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherBtn.FillColor = System.Drawing.Color.Transparent;
            this.otherBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBtn.ForeColor = System.Drawing.Color.Black;
            this.otherBtn.HoverState.Parent = this.otherBtn;
            this.otherBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.otherBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.otherBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.otherBtn.Location = new System.Drawing.Point(0, 180);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.ShadowDecoration.Parent = this.otherBtn;
            this.otherBtn.Size = new System.Drawing.Size(302, 45);
            this.otherBtn.TabIndex = 48;
            this.otherBtn.Text = "Other";
            this.otherBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.otherBtn.TextOffset = new System.Drawing.Point(80, 0);
            // 
            // compositionBtn
            // 
            this.compositionBtn.BackColor = System.Drawing.Color.Transparent;
            this.compositionBtn.CheckedState.Parent = this.compositionBtn;
            this.compositionBtn.CustomImages.Parent = this.compositionBtn;
            this.compositionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.compositionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.compositionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.compositionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.compositionBtn.DisabledState.Parent = this.compositionBtn;
            this.compositionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.compositionBtn.FillColor = System.Drawing.Color.Transparent;
            this.compositionBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compositionBtn.ForeColor = System.Drawing.Color.Black;
            this.compositionBtn.HoverState.Parent = this.compositionBtn;
            this.compositionBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compositionBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.compositionBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.compositionBtn.Location = new System.Drawing.Point(0, 135);
            this.compositionBtn.Name = "compositionBtn";
            this.compositionBtn.ShadowDecoration.Parent = this.compositionBtn;
            this.compositionBtn.Size = new System.Drawing.Size(302, 45);
            this.compositionBtn.TabIndex = 47;
            this.compositionBtn.Text = "Composition";
            this.compositionBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compositionBtn.TextOffset = new System.Drawing.Point(80, 0);
            // 
            // vectorBtn
            // 
            this.vectorBtn.BackColor = System.Drawing.Color.Transparent;
            this.vectorBtn.CheckedState.Parent = this.vectorBtn;
            this.vectorBtn.CustomImages.Parent = this.vectorBtn;
            this.vectorBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.vectorBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.vectorBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.vectorBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.vectorBtn.DisabledState.Parent = this.vectorBtn;
            this.vectorBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vectorBtn.FillColor = System.Drawing.Color.Transparent;
            this.vectorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vectorBtn.ForeColor = System.Drawing.Color.Black;
            this.vectorBtn.HoverState.Parent = this.vectorBtn;
            this.vectorBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vectorBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.vectorBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.vectorBtn.Location = new System.Drawing.Point(0, 90);
            this.vectorBtn.Name = "vectorBtn";
            this.vectorBtn.ShadowDecoration.Parent = this.vectorBtn;
            this.vectorBtn.Size = new System.Drawing.Size(302, 45);
            this.vectorBtn.TabIndex = 46;
            this.vectorBtn.Text = "Vector art";
            this.vectorBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vectorBtn.TextOffset = new System.Drawing.Point(80, 0);
            // 
            // fineArt
            // 
            this.fineArt.BackColor = System.Drawing.Color.Transparent;
            this.fineArt.CheckedState.Parent = this.fineArt;
            this.fineArt.CustomImages.Parent = this.fineArt;
            this.fineArt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fineArt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fineArt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fineArt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fineArt.DisabledState.Parent = this.fineArt;
            this.fineArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.fineArt.FillColor = System.Drawing.Color.Transparent;
            this.fineArt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineArt.ForeColor = System.Drawing.Color.Black;
            this.fineArt.HoverState.Parent = this.fineArt;
            this.fineArt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fineArt.ImageOffset = new System.Drawing.Point(7, 0);
            this.fineArt.ImageSize = new System.Drawing.Size(30, 30);
            this.fineArt.Location = new System.Drawing.Point(0, 45);
            this.fineArt.Name = "fineArt";
            this.fineArt.ShadowDecoration.Parent = this.fineArt;
            this.fineArt.Size = new System.Drawing.Size(302, 45);
            this.fineArt.TabIndex = 44;
            this.fineArt.Text = "Fine art";
            this.fineArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fineArt.TextOffset = new System.Drawing.Point(80, 0);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.categoryBtn.CheckedState.Parent = this.categoryBtn;
            this.categoryBtn.CustomImages.Parent = this.categoryBtn;
            this.categoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categoryBtn.DisabledState.Parent = this.categoryBtn;
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryBtn.FillColor = System.Drawing.Color.Transparent;
            this.categoryBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.Color.Black;
            this.categoryBtn.HoverState.Parent = this.categoryBtn;
            this.categoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoryBtn.Image")));
            this.categoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoryBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.categoryBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.categoryBtn.Location = new System.Drawing.Point(0, 0);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.ShadowDecoration.Parent = this.categoryBtn;
            this.categoryBtn.Size = new System.Drawing.Size(302, 45);
            this.categoryBtn.TabIndex = 11;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.categoryBtn.TextOffset = new System.Drawing.Point(10, 0);
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.CheckedState.Parent = this.homeBtn;
            this.homeBtn.CustomImages.Parent = this.homeBtn;
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.DisabledState.Parent = this.homeBtn;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FillColor = System.Drawing.Color.Transparent;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.HoverState.Parent = this.homeBtn;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.ImageOffset = new System.Drawing.Point(7, 0);
            this.homeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.homeBtn.Location = new System.Drawing.Point(0, 73);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
            this.homeBtn.Size = new System.Drawing.Size(302, 45);
            this.homeBtn.TabIndex = 10;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 73);
            this.panel2.TabIndex = 8;
            // 
            // PostBtn
            // 
            this.PostBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PostBtn.AutoRoundedCorners = true;
            this.PostBtn.BorderRadius = 25;
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
            this.PostBtn.Location = new System.Drawing.Point(39, 522);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Padding = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.PostBtn.ShadowDecoration.Parent = this.PostBtn;
            this.PostBtn.Size = new System.Drawing.Size(214, 53);
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
            this.MainFormPanelBg.Margin = new System.Windows.Forms.Padding(2);
            this.MainFormPanelBg.Name = "MainFormPanelBg";
            this.MainFormPanelBg.ShadowDecoration.Parent = this.MainFormPanelBg;
            this.MainFormPanelBg.Size = new System.Drawing.Size(1145, 665);
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
            this.mainPanel.Location = new System.Drawing.Point(302, 67);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mainPanel.Size = new System.Drawing.Size(843, 598);
            this.mainPanel.TabIndex = 19;
            // 
            // dropDonwTimer
            // 
            this.dropDonwTimer.Enabled = true;
            this.dropDonwTimer.Interval = 1;
            this.dropDonwTimer.Tick += new System.EventHandler(this.dropDonwTimer_Tick);
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = global::Gallery.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1072, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(73, 67);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 67);
            this.panel1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navDrawerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainFormPanelBg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1163, 712);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navDrawerPanel.ResumeLayout(false);
            this.dropDownPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox MainFormPanelBg;
        private Guna.UI2.WinForms.Guna2GradientPanel navDrawerPanel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private Guna.UI2.WinForms.Guna2Button PostBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Button categoryBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer dropDonwTimer;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private System.Windows.Forms.Panel dropDownPanel;
        private Guna.UI2.WinForms.Guna2Button vectorBtn;
        private Guna.UI2.WinForms.Guna2Button compositionBtn;
        private Guna.UI2.WinForms.Guna2Button fineArt;
        private Guna.UI2.WinForms.Guna2Button otherBtn;
        private System.Windows.Forms.Button ArtisticLounge;
        private System.Windows.Forms.Button AboutUsBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button ServicesBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}