namespace Gallery
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
            this.components = new System.ComponentModel.Container();
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
            this.TK = new System.Windows.Forms.Label();
            this.priceBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.postBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.artName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SelectArtBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ArtPicture = new System.Windows.Forms.PictureBox();
            this.errorArtName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArtCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArtPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackToMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PostPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtPrice)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1703, 100);
            this.panel1.TabIndex = 18;
            // 
            // BackToMainForm
            // 
            this.BackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("BackToMainForm.Image")));
            this.BackToMainForm.ImageRotate = 0F;
            this.BackToMainForm.Location = new System.Drawing.Point(1602, 0);
            this.BackToMainForm.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.BackToMainForm.Name = "BackToMainForm";
            this.BackToMainForm.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.BackToMainForm.ShadowDecoration.Parent = this.BackToMainForm;
            this.BackToMainForm.Size = new System.Drawing.Size(101, 100);
            this.BackToMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackToMainForm.TabIndex = 20;
            this.BackToMainForm.TabStop = false;
            this.BackToMainForm.Click += new System.EventHandler(this.BackToMainForm_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 83);
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
            this.ServicesBtn.Location = new System.Drawing.Point(804, 0);
            this.ServicesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(192, 100);
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
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(192, 100);
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
            this.AboutUsBtn.Location = new System.Drawing.Point(420, 0);
            this.AboutUsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutUsBtn.Name = "AboutUsBtn";
            this.AboutUsBtn.Size = new System.Drawing.Size(192, 100);
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
            this.ArtisticLounge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArtisticLounge.Name = "ArtisticLounge";
            this.ArtisticLounge.Size = new System.Drawing.Size(420, 100);
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
            this.PostPanel.Location = new System.Drawing.Point(0, 100);
            this.PostPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostPanel.Name = "PostPanel";
            this.PostPanel.Size = new System.Drawing.Size(1703, 843);
            this.PostPanel.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TK);
            this.panel4.Controls.Add(this.priceBox);
            this.panel4.Controls.Add(this.postBtn);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.categoryBox);
            this.panel4.Controls.Add(this.artName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(840, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 843);
            this.panel4.TabIndex = 1;
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.ForeColor = System.Drawing.Color.DarkRed;
            this.TK.Location = new System.Drawing.Point(407, 504);
            this.TK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(66, 45);
            this.TK.TabIndex = 44;
            this.TK.Text = "TK.";
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.BackColor = System.Drawing.Color.Transparent;
            this.priceBox.BorderColor = System.Drawing.Color.Navy;
            this.priceBox.BorderRadius = 7;
            this.priceBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceBox.DefaultText = "";
            this.priceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceBox.DisabledState.Parent = this.priceBox;
            this.priceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceBox.FocusedState.Parent = this.priceBox;
            this.priceBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.priceBox.ForeColor = System.Drawing.Color.DarkRed;
            this.priceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceBox.HoverState.Parent = this.priceBox;
            this.priceBox.Location = new System.Drawing.Point(126, 498);
            this.priceBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.priceBox.Name = "priceBox";
            this.priceBox.PasswordChar = '\0';
            this.priceBox.PlaceholderText = "";
            this.priceBox.SelectedText = "";
            this.priceBox.ShadowDecoration.Parent = this.priceBox;
            this.priceBox.Size = new System.Drawing.Size(249, 61);
            this.priceBox.TabIndex = 43;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // postBtn
            // 
            this.postBtn.BackColor = System.Drawing.Color.Transparent;
            this.postBtn.BorderColor = System.Drawing.Color.Transparent;
            this.postBtn.BorderRadius = 10;
            this.postBtn.BorderThickness = 2;
            this.postBtn.CheckedState.Parent = this.postBtn;
            this.postBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBtn.CustomImages.Parent = this.postBtn;
            this.postBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.postBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.postBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.postBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.postBtn.DisabledState.Parent = this.postBtn;
            this.postBtn.FillColor = System.Drawing.Color.DarkRed;
            this.postBtn.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBtn.ForeColor = System.Drawing.Color.White;
            this.postBtn.HoverState.Parent = this.postBtn;
            this.postBtn.Location = new System.Drawing.Point(394, 740);
            this.postBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postBtn.Name = "postBtn";
            this.postBtn.ShadowDecoration.Parent = this.postBtn;
            this.postBtn.Size = new System.Drawing.Size(301, 74);
            this.postBtn.TabIndex = 42;
            this.postBtn.Text = "Post";
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(134, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 38);
            this.label3.TabIndex = 41;
            this.label3.Text = "Art Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(134, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 40;
            this.label2.Text = "Art Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(136, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "Art Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryBox.BorderColor = System.Drawing.Color.Navy;
            this.categoryBox.BorderRadius = 7;
            this.categoryBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryBox.FocusedState.Parent = this.categoryBox;
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 11.14286F);
            this.categoryBox.ForeColor = System.Drawing.Color.Navy;
            this.categoryBox.HoverState.Parent = this.categoryBox;
            this.categoryBox.ItemHeight = 30;
            this.categoryBox.Items.AddRange(new object[] {
            "Fine Art",
            "Vector Art",
            "Composition ",
            "Other"});
            this.categoryBox.ItemsAppearance.Parent = this.categoryBox;
            this.categoryBox.Location = new System.Drawing.Point(141, 369);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ShadowDecoration.Parent = this.categoryBox;
            this.categoryBox.Size = new System.Drawing.Size(338, 36);
            this.categoryBox.TabIndex = 37;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // artName
            // 
            this.artName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.artName.BackColor = System.Drawing.Color.Transparent;
            this.artName.BorderColor = System.Drawing.Color.Navy;
            this.artName.BorderRadius = 7;
            this.artName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.artName.DefaultText = "";
            this.artName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.artName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.artName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.artName.DisabledState.Parent = this.artName;
            this.artName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.artName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.artName.FocusedState.Parent = this.artName;
            this.artName.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.artName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.artName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.artName.HoverState.Parent = this.artName;
            this.artName.Location = new System.Drawing.Point(126, 223);
            this.artName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.artName.Name = "artName";
            this.artName.PasswordChar = '\0';
            this.artName.PlaceholderText = "";
            this.artName.SelectedText = "";
            this.artName.ShadowDecoration.Parent = this.artName;
            this.artName.Size = new System.Drawing.Size(535, 61);
            this.artName.TabIndex = 31;
            this.artName.TextChanged += new System.EventHandler(this.artName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SelectArtBtn);
            this.panel3.Controls.Add(this.ArtPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 843);
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
            this.SelectArtBtn.Location = new System.Drawing.Point(332, 635);
            this.SelectArtBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectArtBtn.Name = "SelectArtBtn";
            this.SelectArtBtn.ShadowDecoration.Parent = this.SelectArtBtn;
            this.SelectArtBtn.Size = new System.Drawing.Size(238, 68);
            this.SelectArtBtn.TabIndex = 32;
            this.SelectArtBtn.Text = "Select Art";
            this.SelectArtBtn.Click += new System.EventHandler(this.SelectArtBtn_Click);
            // 
            // ArtPicture
            // 
            this.ArtPicture.BackColor = System.Drawing.Color.Transparent;
            this.ArtPicture.Image = ((System.Drawing.Image)(resources.GetObject("ArtPicture.Image")));
            this.ArtPicture.Location = new System.Drawing.Point(48, 70);
            this.ArtPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArtPicture.Name = "ArtPicture";
            this.ArtPicture.Size = new System.Drawing.Size(792, 532);
            this.ArtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArtPicture.TabIndex = 1;
            this.ArtPicture.TabStop = false;
            this.ArtPicture.Click += new System.EventHandler(this.ArtPicture_Click);
            // 
            // errorArtName
            // 
            this.errorArtName.ContainerControl = this;
            // 
            // errorArtCategory
            // 
            this.errorArtCategory.ContainerControl = this;
            // 
            // errorArtPrice
            // 
            this.errorArtPrice.ContainerControl = this;
            // 
            // PostArtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 943);
            this.Controls.Add(this.PostPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1727, 1007);
            this.MinimumSize = new System.Drawing.Size(1727, 1007);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArtPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArtPrice)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ComboBox categoryBox;
        private Guna.UI2.WinForms.Guna2TextBox artName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button postBtn;
        private Guna.UI2.WinForms.Guna2PictureBox BackToMainForm;
        private System.Windows.Forms.ErrorProvider errorArtName;
        private System.Windows.Forms.ErrorProvider errorArtCategory;
        private System.Windows.Forms.ErrorProvider errorArtPrice;
        private Guna.UI2.WinForms.Guna2TextBox priceBox;
        private System.Windows.Forms.Label TK;
    }
}