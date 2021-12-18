namespace Gallery
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.msgGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.cancleBtn);
            this.panel1.Controls.Add(this.msgGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1654, 964);
            this.panel1.TabIndex = 0;
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
            this.deleteBtn.Location = new System.Drawing.Point(1020, 22);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(307, 68);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete Message";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.cancleBtn.Location = new System.Drawing.Point(1335, 22);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.ShadowDecoration.Parent = this.cancleBtn;
            this.cancleBtn.Size = new System.Drawing.Size(307, 68);
            this.cancleBtn.TabIndex = 24;
            this.cancleBtn.Text = "Back";
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // msgGridView
            // 
            this.msgGridView.AllowUserToAddRows = false;
            this.msgGridView.AllowUserToDeleteRows = false;
            this.msgGridView.AllowUserToResizeColumns = false;
            this.msgGridView.AllowUserToResizeRows = false;
            this.msgGridView.BackgroundColor = System.Drawing.Color.White;
            this.msgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msgGridView.Location = new System.Drawing.Point(0, 111);
            this.msgGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.msgGridView.MaximumSize = new System.Drawing.Size(1654, 853);
            this.msgGridView.MinimumSize = new System.Drawing.Size(1654, 853);
            this.msgGridView.Name = "msgGridView";
            this.msgGridView.ReadOnly = true;
            this.msgGridView.RowHeadersVisible = false;
            this.msgGridView.RowHeadersWidth = 72;
            this.msgGridView.RowTemplate.Height = 125;
            this.msgGridView.Size = new System.Drawing.Size(1654, 853);
            this.msgGridView.TabIndex = 3;
            this.msgGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msgGridView_CellClick);
            this.msgGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msgGridView_CellContentClick);
            this.msgGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.msgGridView_DataBindingComplete);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 964);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1678, 1028);
            this.MinimumSize = new System.Drawing.Size(1678, 1028);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button cancleBtn;
        private System.Windows.Forms.DataGridView msgGridView;
    }
}