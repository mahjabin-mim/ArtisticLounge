namespace Gallery
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.LouOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PendingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MsgBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1661, 984);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.SeaShell;
            this.AdminPanel.Controls.Add(this.MsgBtn);
            this.AdminPanel.Controls.Add(this.LouOutBtn);
            this.AdminPanel.Controls.Add(this.PendingBtn);
            this.AdminPanel.Controls.Add(this.UserBtn);
            this.AdminPanel.Controls.Add(this.label1);
            this.AdminPanel.Controls.Add(this.pictureBox1);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(1661, 984);
            this.AdminPanel.TabIndex = 16;
            // 
            // LouOutBtn
            // 
            this.LouOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LouOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LouOutBtn.BorderRadius = 7;
            this.LouOutBtn.CheckedState.Parent = this.LouOutBtn;
            this.LouOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LouOutBtn.CustomImages.Parent = this.LouOutBtn;
            this.LouOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LouOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LouOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LouOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LouOutBtn.DisabledState.Parent = this.LouOutBtn;
            this.LouOutBtn.FillColor = System.Drawing.Color.Navy;
            this.LouOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LouOutBtn.ForeColor = System.Drawing.Color.White;
            this.LouOutBtn.HoverState.Parent = this.LouOutBtn;
            this.LouOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LouOutBtn.Image")));
            this.LouOutBtn.Location = new System.Drawing.Point(935, 684);
            this.LouOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LouOutBtn.Name = "LouOutBtn";
            this.LouOutBtn.ShadowDecoration.Parent = this.LouOutBtn;
            this.LouOutBtn.Size = new System.Drawing.Size(284, 77);
            this.LouOutBtn.TabIndex = 18;
            this.LouOutBtn.Text = "Log Out";
            this.LouOutBtn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // PendingBtn
            // 
            this.PendingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PendingBtn.BackColor = System.Drawing.Color.Transparent;
            this.PendingBtn.BorderRadius = 7;
            this.PendingBtn.CheckedState.Parent = this.PendingBtn;
            this.PendingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PendingBtn.CustomImages.Parent = this.PendingBtn;
            this.PendingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PendingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PendingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PendingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PendingBtn.DisabledState.Parent = this.PendingBtn;
            this.PendingBtn.FillColor = System.Drawing.Color.Navy;
            this.PendingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingBtn.ForeColor = System.Drawing.Color.White;
            this.PendingBtn.HoverState.Parent = this.PendingBtn;
            this.PendingBtn.Image = ((System.Drawing.Image)(resources.GetObject("PendingBtn.Image")));
            this.PendingBtn.Location = new System.Drawing.Point(444, 684);
            this.PendingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PendingBtn.Name = "PendingBtn";
            this.PendingBtn.ShadowDecoration.Parent = this.PendingBtn;
            this.PendingBtn.Size = new System.Drawing.Size(284, 77);
            this.PendingBtn.TabIndex = 17;
            this.PendingBtn.Text = "Pending Arts";
            this.PendingBtn.Click += new System.EventHandler(this.PendingBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserBtn.BorderRadius = 7;
            this.UserBtn.CheckedState.Parent = this.UserBtn;
            this.UserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBtn.CustomImages.Parent = this.UserBtn;
            this.UserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserBtn.DisabledState.Parent = this.UserBtn;
            this.UserBtn.FillColor = System.Drawing.Color.Navy;
            this.UserBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UserBtn.ForeColor = System.Drawing.Color.White;
            this.UserBtn.HoverState.Parent = this.UserBtn;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.Location = new System.Drawing.Point(444, 580);
            this.UserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.ShadowDecoration.Parent = this.UserBtn;
            this.UserBtn.Size = new System.Drawing.Size(284, 77);
            this.UserBtn.TabIndex = 16;
            this.UserBtn.Text = "Users";
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(588, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 98);
            this.label1.TabIndex = 15;
            this.label1.Text = "Artistic Lounge";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(757, 209);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MsgBtn
            // 
            this.MsgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBtn.BackColor = System.Drawing.Color.Transparent;
            this.MsgBtn.BorderRadius = 7;
            this.MsgBtn.CheckedState.Parent = this.MsgBtn;
            this.MsgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MsgBtn.CustomImages.Parent = this.MsgBtn;
            this.MsgBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MsgBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MsgBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MsgBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MsgBtn.DisabledState.Parent = this.MsgBtn;
            this.MsgBtn.FillColor = System.Drawing.Color.Navy;
            this.MsgBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgBtn.ForeColor = System.Drawing.Color.White;
            this.MsgBtn.HoverState.Parent = this.MsgBtn;
            this.MsgBtn.Image = ((System.Drawing.Image)(resources.GetObject("MsgBtn.Image")));
            this.MsgBtn.Location = new System.Drawing.Point(935, 580);
            this.MsgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MsgBtn.Name = "MsgBtn";
            this.MsgBtn.ShadowDecoration.Parent = this.MsgBtn;
            this.MsgBtn.Size = new System.Drawing.Size(284, 77);
            this.MsgBtn.TabIndex = 22;
            this.MsgBtn.Text = "Messages";
            this.MsgBtn.Click += new System.EventHandler(this.MsgBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 984);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1685, 1048);
            this.MinimumSize = new System.Drawing.Size(1685, 1048);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel AdminPanel;
        private Guna.UI2.WinForms.Guna2Button LouOutBtn;
        private Guna.UI2.WinForms.Guna2Button PendingBtn;
        private Guna.UI2.WinForms.Guna2Button UserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button MsgBtn;
    }
}