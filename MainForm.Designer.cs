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
            this.MainFormPanelBg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.AboutusBtn = new System.Windows.Forms.Button();
            this.navDrawerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 100);
            this.panel1.TabIndex = 17;
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
            this.ServiceBtn.Location = new System.Drawing.Point(545, 0);
            this.ServiceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(169, 100);
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
            this.ContactBtn.Location = new System.Drawing.Point(376, 0);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(169, 100);
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
            this.AboutusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AboutusBtn.Name = "AboutusBtn";
            this.AboutusBtn.Size = new System.Drawing.Size(376, 100);
            this.AboutusBtn.TabIndex = 1;
            this.AboutusBtn.Text = "Artistic Lounge";
            this.AboutusBtn.UseVisualStyleBackColor = false;
            this.AboutusBtn.Click += new System.EventHandler(this.AboutusBtn_Click);
            // 
            // navDrawerPanel
            // 
            this.navDrawerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.navDrawerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navDrawerPanel.Location = new System.Drawing.Point(0, 100);
            this.navDrawerPanel.Name = "navDrawerPanel";
            this.navDrawerPanel.ShadowDecoration.Parent = this.navDrawerPanel;
            this.navDrawerPanel.Size = new System.Drawing.Size(376, 898);
            this.navDrawerPanel.TabIndex = 18;
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
            this.button1.Location = new System.Drawing.Point(714, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlowPanel.Location = new System.Drawing.Point(376, 100);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(1198, 898);
            this.MainFlowPanel.TabIndex = 19;
            this.MainFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFlowPanel_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = global::Gallery.Properties.Resources.user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1460, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Padding = new System.Windows.Forms.Padding(15);
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(114, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 998);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.navDrawerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainFormPanelBg);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPanelBg)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel MainFlowPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}