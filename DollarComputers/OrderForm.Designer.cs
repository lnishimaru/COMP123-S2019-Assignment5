﻿namespace DollarComputers
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.FinishOrderButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.BackOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.Location = new System.Drawing.Point(890, 540);
            this.FinishOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(105, 40);
            this.FinishOrderButton.TabIndex = 8;
            this.FinishOrderButton.Text = "Finish";
            this.FinishOrderButton.UseVisualStyleBackColor = true;
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Location = new System.Drawing.Point(783, 540);
            this.CancelOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(105, 40);
            this.CancelOrderButton.TabIndex = 7;
            this.CancelOrderButton.Text = "Cancel";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // BackOrderButton
            // 
            this.BackOrderButton.Location = new System.Drawing.Point(675, 540);
            this.BackOrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackOrderButton.Name = "BackOrderButton";
            this.BackOrderButton.Size = new System.Drawing.Size(105, 40);
            this.BackOrderButton.TabIndex = 9;
            this.BackOrderButton.Text = "Back";
            this.BackOrderButton.UseVisualStyleBackColor = true;
            this.BackOrderButton.Click += new System.EventHandler(this.BackOrderButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.ControlBox = false;
            this.Controls.Add(this.BackOrderButton);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.CancelOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete your Order";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FinishOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button BackOrderButton;
    }
}