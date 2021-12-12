namespace Gallery
{
    partial class ArtOnStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtOnStockCard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ArtImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ArtName = new System.Windows.Forms.Label();
            this.ArtPrice = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.ArtImage);
            this.guna2Panel1.Controls.Add(this.DeleteBtn);
            this.guna2Panel1.Controls.Add(this.ArtName);
            this.guna2Panel1.Controls.Add(this.ArtPrice);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(28, 68, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(374, 525);
            this.guna2Panel1.TabIndex = 5;
            // 
            // ArtImage
            // 
            this.ArtImage.Image = ((System.Drawing.Image)(resources.GetObject("ArtImage.Image")));
            this.ArtImage.ImageRotate = 0F;
            this.ArtImage.Location = new System.Drawing.Point(7, 4);
            this.ArtImage.Margin = new System.Windows.Forms.Padding(4);
            this.ArtImage.Name = "ArtImage";
            this.ArtImage.ShadowDecoration.Parent = this.ArtImage;
            this.ArtImage.Size = new System.Drawing.Size(364, 244);
            this.ArtImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArtImage.TabIndex = 0;
            this.ArtImage.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderColor = System.Drawing.Color.Red;
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.BorderThickness = 2;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.DisabledState.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Red;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
            this.DeleteBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.DeleteBtn.Location = new System.Drawing.Point(87, 423);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(190, 56);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ArtName
            // 
            this.ArtName.AutoSize = true;
            this.ArtName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtName.Location = new System.Drawing.Point(-3, 267);
            this.ArtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtName.Name = "ArtName";
            this.ArtName.Size = new System.Drawing.Size(141, 51);
            this.ArtName.TabIndex = 1;
            this.ArtName.Text = "Galaxy";
            // 
            // ArtPrice
            // 
            this.ArtPrice.AutoSize = true;
            this.ArtPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtPrice.ForeColor = System.Drawing.Color.Red;
            this.ArtPrice.Location = new System.Drawing.Point(7, 324);
            this.ArtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArtPrice.Name = "ArtPrice";
            this.ArtPrice.Size = new System.Drawing.Size(111, 38);
            this.ArtPrice.TabIndex = 2;
            this.ArtPrice.Text = "900 Tk.";
            this.ArtPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArtOnStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(28, 68, 4, 4);
            this.Name = "ArtOnStockCard";
            this.Size = new System.Drawing.Size(371, 525);
            this.Load += new System.EventHandler(this.ArtOnStockCard_Load_1);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ArtImage;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private System.Windows.Forms.Label ArtName;
        private System.Windows.Forms.Label ArtPrice;
    }
}
