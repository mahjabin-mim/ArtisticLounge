namespace Gallery
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cancleBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.usersGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 536);
            this.panel1.TabIndex = 1;
            // 
            // cancleBtn
            // 
            this.cancleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancleBtn.BorderRadius = 7;
            this.cancleBtn.CheckedState.Parent = this.cancleBtn;
            this.cancleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleBtn.CustomImages.Parent = this.cancleBtn;
            this.cancleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancleBtn.DisabledState.Parent = this.cancleBtn;
            this.cancleBtn.FillColor = System.Drawing.Color.Navy;
            this.cancleBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancleBtn.ForeColor = System.Drawing.Color.White;
            this.cancleBtn.HoverState.Parent = this.cancleBtn;
            this.cancleBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancleBtn.Image")));
            this.cancleBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.cancleBtn.Location = new System.Drawing.Point(761, 10);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.ShadowDecoration.Parent = this.cancleBtn;
            this.cancleBtn.Size = new System.Drawing.Size(133, 37);
            this.cancleBtn.TabIndex = 21;
            this.cancleBtn.Text = "Back";
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderRadius = 12;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.Parent = this.searchBox;
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.FocusedState.Parent = this.searchBox;
            this.searchBox.Font = new System.Drawing.Font("Cambria", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.Location = new System.Drawing.Point(7, 12);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Search...";
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.BorderRadius = 12;
            this.searchBox.ShadowDecoration.Enabled = true;
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.searchBox.Size = new System.Drawing.Size(612, 31);
            this.searchBox.TabIndex = 20;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderRadius = 7;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.DisabledState.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.deleteBtn.Location = new System.Drawing.Point(625, 10);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(133, 37);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete User";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeColumns = false;
            this.usersGridView.AllowUserToResizeRows = false;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersGridView.Location = new System.Drawing.Point(0, 74);
            this.usersGridView.MaximumSize = new System.Drawing.Size(902, 462);
            this.usersGridView.MinimumSize = new System.Drawing.Size(902, 462);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidth = 72;
            this.usersGridView.RowTemplate.Height = 100;
            this.usersGridView.Size = new System.Drawing.Size(902, 462);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellClick);
            this.usersGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellMouseEnter);
            this.usersGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellMouseLeave);
            this.usersGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersGridView_DataBindingComplete);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(923, 575);
            this.MinimumSize = new System.Drawing.Size(923, 575);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button cancleBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
    }
}