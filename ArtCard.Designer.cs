namespace Gallery
{
    partial class ArtCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtCard));
            this.artImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.arttitle = new System.Windows.Forms.Label();
            this.artPrice = new System.Windows.Forms.Label();
            this.buyNowBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.artImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // artImage
            // 
            this.artImage.Image = ((System.Drawing.Image)(resources.GetObject("artImage.Image")));
            this.artImage.ImageRotate = 0F;
            this.artImage.Location = new System.Drawing.Point(4, 4);
            this.artImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artImage.Name = "artImage";
            this.artImage.ShadowDecoration.Parent = this.artImage;
            this.artImage.Size = new System.Drawing.Size(387, 279);
            this.artImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.artImage.TabIndex = 0;
            this.artImage.TabStop = false;
            // 
            // arttitle
            // 
            this.arttitle.AutoSize = true;
            this.arttitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arttitle.Location = new System.Drawing.Point(-6, 286);
            this.arttitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arttitle.Name = "arttitle";
            this.arttitle.Size = new System.Drawing.Size(141, 51);
            this.arttitle.TabIndex = 1;
            this.arttitle.Text = "Galaxy";
            this.arttitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // artPrice
            // 
            this.artPrice.AutoSize = true;
            this.artPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artPrice.ForeColor = System.Drawing.Color.Red;
            this.artPrice.Location = new System.Drawing.Point(4, 356);
            this.artPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artPrice.Name = "artPrice";
            this.artPrice.Size = new System.Drawing.Size(111, 38);
            this.artPrice.TabIndex = 2;
            this.artPrice.Text = "900 Tk.";
            // 
            // buyNowBtn
            // 
            this.buyNowBtn.BorderRadius = 7;
            this.buyNowBtn.CheckedState.Parent = this.buyNowBtn;
            this.buyNowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyNowBtn.CustomImages.Parent = this.buyNowBtn;
            this.buyNowBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buyNowBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buyNowBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buyNowBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buyNowBtn.DisabledState.Parent = this.buyNowBtn;
            this.buyNowBtn.FillColor = System.Drawing.Color.DarkRed;
            this.buyNowBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyNowBtn.ForeColor = System.Drawing.Color.White;
            this.buyNowBtn.HoverState.Parent = this.buyNowBtn;
            this.buyNowBtn.Location = new System.Drawing.Point(114, 471);
            this.buyNowBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyNowBtn.Name = "buyNowBtn";
            this.buyNowBtn.ShadowDecoration.Parent = this.buyNowBtn;
            this.buyNowBtn.Size = new System.Drawing.Size(156, 55);
            this.buyNowBtn.TabIndex = 3;
            this.buyNowBtn.Text = "Buy now";
            this.buyNowBtn.Click += new System.EventHandler(this.buyNowBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.artImage);
            this.guna2Panel1.Controls.Add(this.buyNowBtn);
            this.guna2Panel1.Controls.Add(this.arttitle);
            this.guna2Panel1.Controls.Add(this.artPrice);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 4);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 552);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // ArtCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(28, 68, 4, 4);
            this.Name = "ArtCard";
            this.Size = new System.Drawing.Size(400, 556);
            this.Load += new System.EventHandler(this.ArtCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox artImage;
        private System.Windows.Forms.Label arttitle;
        private System.Windows.Forms.Label artPrice;
        private Guna.UI2.WinForms.Guna2Button buyNowBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
