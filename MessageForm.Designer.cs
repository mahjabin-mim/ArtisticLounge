﻿namespace Gallery
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
            this.msgGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancleBtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 984);
            this.panel1.TabIndex = 0;
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
            this.msgGridView.Location = new System.Drawing.Point(0, 112);
            this.msgGridView.Margin = new System.Windows.Forms.Padding(6);
            this.msgGridView.Name = "msgGridView";
            this.msgGridView.RowHeadersVisible = false;
            this.msgGridView.RowHeadersWidth = 72;
            this.msgGridView.RowTemplate.Height = 125;
            this.msgGridView.Size = new System.Drawing.Size(1661, 872);
            this.msgGridView.TabIndex = 3;
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
            this.deleteBtn.Location = new System.Drawing.Point(1012, 22);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(314, 68);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete Message";
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
            this.cancleBtn.Location = new System.Drawing.Point(1334, 22);
            this.cancleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.ShadowDecoration.Parent = this.cancleBtn;
            this.cancleBtn.Size = new System.Drawing.Size(314, 68);
            this.cancleBtn.TabIndex = 24;
            this.cancleBtn.Text = "Back";
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 984);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1685, 1048);
            this.MinimumSize = new System.Drawing.Size(1685, 1048);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
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