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
            this.button1 = new System.Windows.Forms.Button();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutusBtn = new System.Windows.Forms.Button();
            this.navDrawerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainFormPanelBg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ServiceBtn);
            this.panel1.Controls.Add(this.ContactBtn);
            this.panel1.Controls.Add(this.AboutusBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 67);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(519, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ServiceBtn.Location = new System.Drawing.Point(396, 0);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(123, 67);
            this.ServiceBtn.TabIndex = 0;
            this.ServiceBtn.Text = "Contact";
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
            this.ContactBtn.Location = new System.Drawing.Point(273, 0);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(123, 67);
            this.ContactBtn.TabIndex = 2;
            this.ContactBtn.Text = "About Us";
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
            this.AboutusBtn.Font = new System.Drawing.Font("Segoe Print", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutusBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AboutusBtn.Location = new System.Drawing.Point(0, 0);
            this.AboutusBtn.Name = "AboutusBtn";
            this.AboutusBtn.Size = new System.Drawing.Size(273, 67);
            this.AboutusBtn.TabIndex = 1;
            this.AboutusBtn.Text = "Artistic Lounge";
            this.AboutusBtn.UseVisualStyleBackColor = false;
            this.AboutusBtn.Click += new System.EventHandler(this.AboutusBtn_Click);
            // 
            // navDrawerPanel
            // 
            this.navDrawerPanel.AutoScroll = true;
            this.navDrawerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.navDrawerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDrawerPanel.Location = new System.Drawing.Point(0, 67);
            this.navDrawerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.navDrawerPanel.Name = "navDrawerPanel";
            this.navDrawerPanel.ShadowDecoration.Parent = this.navDrawerPanel;
            this.navDrawerPanel.Size = new System.Drawing.Size(273, 598);
            this.navDrawerPanel.TabIndex = 18;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = global::Gallery.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1062, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(83, 67);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
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
            this.mainPanel.Location = new System.Drawing.Point(273, 67);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.mainPanel.Size = new System.Drawing.Size(872, 598);
            this.mainPanel.TabIndex = 19;
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
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox MainFormPanelBg;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel navDrawerPanel;
        private System.Windows.Forms.Button ServiceBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button AboutusBtn;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
    }
}