namespace Gallery
{
    partial class BuyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ArtisticLounge = new System.Windows.Forms.Button();
            this.buyArtrightPanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.proceedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.buyArtleftPanel = new System.Windows.Forms.Panel();
            this.priceLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.artNameLabel = new System.Windows.Forms.Label();
            this.artPicture = new System.Windows.Forms.PictureBox();
            this.buyFormBg = new System.Windows.Forms.PictureBox();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneError = new System.Windows.Forms.ErrorProvider(this.components);
            this.locationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.buyArtrightPanel.SuspendLayout();
            this.buyArtleftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyFormBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ArtisticLounge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 100);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
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
            this.ArtisticLounge.TabIndex = 7;
            this.ArtisticLounge.Text = "Artistic Lounge";
            this.ArtisticLounge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtisticLounge.UseVisualStyleBackColor = false;
            // 
            // buyArtrightPanel
            // 
            this.buyArtrightPanel.BackColor = System.Drawing.Color.Silver;
            this.buyArtrightPanel.Controls.Add(this.nameTextBox);
            this.buyArtrightPanel.Controls.Add(this.BackBtn);
            this.buyArtrightPanel.Controls.Add(this.proceedBtn);
            this.buyArtrightPanel.Controls.Add(this.addressTextBox);
            this.buyArtrightPanel.Controls.Add(this.phoneTextBox);
            this.buyArtrightPanel.Controls.Add(this.emailTextBox);
            this.buyArtrightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyArtrightPanel.Location = new System.Drawing.Point(741, 100);
            this.buyArtrightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyArtrightPanel.Name = "buyArtrightPanel";
            this.buyArtrightPanel.Size = new System.Drawing.Size(959, 832);
            this.buyArtrightPanel.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BorderColor = System.Drawing.Color.White;
            this.nameTextBox.BorderRadius = 7;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.Parent = this.nameTextBox;
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.FocusedState.Parent = this.nameTextBox;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.HoverState.Parent = this.nameTextBox;
            this.nameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("nameTextBox.IconLeft")));
            this.nameTextBox.Location = new System.Drawing.Point(234, 137);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Name....";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.ShadowDecoration.Parent = this.nameTextBox;
            this.nameTextBox.Size = new System.Drawing.Size(535, 70);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 10;
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.DisabledState.Parent = this.BackBtn;
            this.BackBtn.FillColor = System.Drawing.Color.Navy;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(247, 626);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(248, 68);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back ";
            this.BackBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // proceedBtn
            // 
            this.proceedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedBtn.BorderColor = System.Drawing.Color.Transparent;
            this.proceedBtn.BorderRadius = 10;
            this.proceedBtn.CheckedState.Parent = this.proceedBtn;
            this.proceedBtn.CustomImages.Parent = this.proceedBtn;
            this.proceedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.proceedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.proceedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.proceedBtn.DisabledState.Parent = this.proceedBtn;
            this.proceedBtn.FillColor = System.Drawing.Color.Navy;
            this.proceedBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColor = System.Drawing.Color.White;
            this.proceedBtn.HoverState.Parent = this.proceedBtn;
            this.proceedBtn.Location = new System.Drawing.Point(504, 626);
            this.proceedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.ShadowDecoration.Parent = this.proceedBtn;
            this.proceedBtn.Size = new System.Drawing.Size(248, 68);
            this.proceedBtn.TabIndex = 4;
            this.proceedBtn.Text = "Proceed to pay";
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.BackColor = System.Drawing.Color.Transparent;
            this.addressTextBox.BorderColor = System.Drawing.Color.White;
            this.addressTextBox.BorderRadius = 7;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.Parent = this.addressTextBox;
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.FocusedState.Parent = this.addressTextBox;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.HoverState.Parent = this.addressTextBox;
            this.addressTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("addressTextBox.IconLeft")));
            this.addressTextBox.Location = new System.Drawing.Point(234, 486);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Location...";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.ShadowDecoration.Parent = this.addressTextBox;
            this.addressTextBox.Size = new System.Drawing.Size(535, 70);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BorderColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderRadius = 7;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.Parent = this.phoneTextBox;
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.FocusedState.Parent = this.phoneTextBox;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.HoverState.Parent = this.phoneTextBox;
            this.phoneTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("phoneTextBox.IconLeft")));
            this.phoneTextBox.Location = new System.Drawing.Point(234, 366);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Phone...";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.ShadowDecoration.Parent = this.phoneTextBox;
            this.phoneTextBox.Size = new System.Drawing.Size(535, 70);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BorderColor = System.Drawing.Color.White;
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
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("emailTextBox.IconLeft")));
            this.emailTextBox.Location = new System.Drawing.Point(234, 247);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email....";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(535, 70);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // buyArtleftPanel
            // 
            this.buyArtleftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buyArtleftPanel.BackgroundImage")));
            this.buyArtleftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buyArtleftPanel.Controls.Add(this.priceLabel);
            this.buyArtleftPanel.Controls.Add(this.codeLabel);
            this.buyArtleftPanel.Controls.Add(this.categoryLabel);
            this.buyArtleftPanel.Controls.Add(this.artistNameLabel);
            this.buyArtleftPanel.Controls.Add(this.guna2Panel2);
            this.buyArtleftPanel.Controls.Add(this.guna2Panel1);
            this.buyArtleftPanel.Controls.Add(this.artNameLabel);
            this.buyArtleftPanel.Controls.Add(this.artPicture);
            this.buyArtleftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buyArtleftPanel.Location = new System.Drawing.Point(0, 100);
            this.buyArtleftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyArtleftPanel.Name = "buyArtleftPanel";
            this.buyArtleftPanel.Size = new System.Drawing.Size(741, 832);
            this.buyArtleftPanel.TabIndex = 19;
            this.buyArtleftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buyArtleftPanel_Paint);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.Red;
            this.priceLabel.Location = new System.Drawing.Point(73, 785);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(136, 51);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "900 Tk";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(73, 696);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(233, 38);
            this.codeLabel.TabIndex = 9;
            this.codeLabel.Text = "Product code: 007";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(75, 635);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(219, 38);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category: Vector";
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.artistNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistNameLabel.Location = new System.Drawing.Point(75, 574);
            this.artistNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(219, 38);
            this.artistNameLabel.TabIndex = 7;
            this.artistNameLabel.Text = "Art by: Mahjabin";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.IndianRed;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(75, 761);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(578, 2);
            this.guna2Panel2.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.IndianRed;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(75, 539);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(578, 2);
            this.guna2Panel1.TabIndex = 5;
            // 
            // artNameLabel
            // 
            this.artNameLabel.AutoSize = true;
            this.artNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.artNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artNameLabel.Location = new System.Drawing.Point(66, 443);
            this.artNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artNameLabel.Name = "artNameLabel";
            this.artNameLabel.Size = new System.Drawing.Size(213, 45);
            this.artNameLabel.TabIndex = 1;
            this.artNameLabel.Text = "Soft Painting";
            // 
            // artPicture
            // 
            this.artPicture.Image = ((System.Drawing.Image)(resources.GetObject("artPicture.Image")));
            this.artPicture.Location = new System.Drawing.Point(75, 46);
            this.artPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artPicture.Name = "artPicture";
            this.artPicture.Size = new System.Drawing.Size(578, 353);
            this.artPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.artPicture.TabIndex = 0;
            this.artPicture.TabStop = false;
            // 
            // buyFormBg
            // 
            this.buyFormBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyFormBg.Image = ((System.Drawing.Image)(resources.GetObject("buyFormBg.Image")));
            this.buyFormBg.Location = new System.Drawing.Point(0, 0);
            this.buyFormBg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyFormBg.Name = "buyFormBg";
            this.buyFormBg.Size = new System.Drawing.Size(1700, 932);
            this.buyFormBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buyFormBg.TabIndex = 0;
            this.buyFormBg.TabStop = false;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // phoneError
            // 
            this.phoneError.ContainerControl = this;
            // 
            // locationError
            // 
            this.locationError.ContainerControl = this;
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 932);
            this.Controls.Add(this.buyArtrightPanel);
            this.Controls.Add(this.buyArtleftPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buyFormBg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1724, 996);
            this.MinimumSize = new System.Drawing.Size(1724, 996);
            this.Name = "BuyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyForm";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.buyArtrightPanel.ResumeLayout(false);
            this.buyArtleftPanel.ResumeLayout(false);
            this.buyArtleftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyFormBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buyFormBg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ArtisticLounge;
        private System.Windows.Forms.Panel buyArtleftPanel;
        private System.Windows.Forms.PictureBox artPicture;
        private System.Windows.Forms.Label artNameLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Panel buyArtrightPanel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2Button proceedBtn;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.ErrorProvider phoneError;
        private System.Windows.Forms.ErrorProvider locationError;
    }
}