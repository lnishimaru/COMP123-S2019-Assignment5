namespace DollarComputers
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.SelectLabel = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrder = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(336, 51);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(398, 36);
            this.SelectLabel.TabIndex = 0;
            this.SelectLabel.Text = "Order Your Computer Today!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(366, 358);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(298, 55);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrder
            // 
            this.OpenSavedOrder.Location = new System.Drawing.Point(366, 430);
            this.OpenSavedOrder.Name = "OpenSavedOrder";
            this.OpenSavedOrder.Size = new System.Drawing.Size(298, 55);
            this.OpenSavedOrder.TabIndex = 2;
            this.OpenSavedOrder.Text = "Open a Saved Order";
            this.OpenSavedOrder.UseVisualStyleBackColor = true;
            this.OpenSavedOrder.Click += new System.EventHandler(this.OpenSavedOrder_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(366, 505);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(298, 55);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CartPictureBox
            // 
            this.CartPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CartPictureBox.Image")));
            this.CartPictureBox.Location = new System.Drawing.Point(415, 129);
            this.CartPictureBox.Name = "CartPictureBox";
            this.CartPictureBox.Size = new System.Drawing.Size(200, 178);
            this.CartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartPictureBox.TabIndex = 4;
            this.CartPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.ControlBox = false;
            this.Controls.Add(this.CartPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenSavedOrder);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.SelectLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.CartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrder;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox CartPictureBox;
    }
}