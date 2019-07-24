namespace DollarComputers
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.SelectionInfoLabel = new System.Windows.Forms.Label();
            this.CancelSelectButton = new System.Windows.Forms.Button();
            this.NextSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(11, 10);
            this.SelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(250, 29);
            this.SelectionLabel.TabIndex = 0;
            this.SelectionLabel.Text = "Select your Hardware:";
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Location = new System.Drawing.Point(6, 513);
            this.YourSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(177, 29);
            this.YourSelectionLabel.TabIndex = 1;
            this.YourSelectionLabel.Text = "Your Selection:";
            // 
            // SelectionInfoLabel
            // 
            this.SelectionInfoLabel.BackColor = System.Drawing.Color.White;
            this.SelectionInfoLabel.Location = new System.Drawing.Point(179, 515);
            this.SelectionInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectionInfoLabel.Name = "SelectionInfoLabel";
            this.SelectionInfoLabel.Size = new System.Drawing.Size(370, 29);
            this.SelectionInfoLabel.TabIndex = 2;
            // 
            // CancelSelectButton
            // 
            this.CancelSelectButton.Location = new System.Drawing.Point(556, 507);
            this.CancelSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSelectButton.Name = "CancelSelectButton";
            this.CancelSelectButton.Size = new System.Drawing.Size(105, 40);
            this.CancelSelectButton.TabIndex = 3;
            this.CancelSelectButton.Text = "Cancel";
            this.CancelSelectButton.UseVisualStyleBackColor = true;
            this.CancelSelectButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextSelectButton
            // 
            this.NextSelectButton.Location = new System.Drawing.Point(666, 507);
            this.NextSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextSelectButton.Name = "NextSelectButton";
            this.NextSelectButton.Size = new System.Drawing.Size(105, 40);
            this.NextSelectButton.TabIndex = 4;
            this.NextSelectButton.Text = "Next";
            this.NextSelectButton.UseVisualStyleBackColor = true;
            this.NextSelectButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.NextSelectButton);
            this.Controls.Add(this.CancelSelectButton);
            this.Controls.Add(this.SelectionInfoLabel);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.SelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Label SelectionInfoLabel;
        private System.Windows.Forms.Button CancelSelectButton;
        private System.Windows.Forms.Button NextSelectButton;
    }
}