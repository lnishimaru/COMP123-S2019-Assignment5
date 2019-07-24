namespace DollarComputers
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.NextProductInfoButton = new System.Windows.Forms.Button();
            this.CancelProductInfoButton = new System.Windows.Forms.Button();
            this.SelectAnotherProductInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextProductInfoButton
            // 
            this.NextProductInfoButton.Location = new System.Drawing.Point(655, 502);
            this.NextProductInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextProductInfoButton.Name = "NextProductInfoButton";
            this.NextProductInfoButton.Size = new System.Drawing.Size(105, 40);
            this.NextProductInfoButton.TabIndex = 6;
            this.NextProductInfoButton.Text = "Next";
            this.NextProductInfoButton.UseVisualStyleBackColor = true;
            // 
            // CancelProductInfoButton
            // 
            this.CancelProductInfoButton.Location = new System.Drawing.Point(548, 502);
            this.CancelProductInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelProductInfoButton.Name = "CancelProductInfoButton";
            this.CancelProductInfoButton.Size = new System.Drawing.Size(105, 40);
            this.CancelProductInfoButton.TabIndex = 5;
            this.CancelProductInfoButton.Text = "Cancel";
            this.CancelProductInfoButton.UseVisualStyleBackColor = true;
            // 
            // SelectAnotherProductInfoButton
            // 
            this.SelectAnotherProductInfoButton.Location = new System.Drawing.Point(266, 502);
            this.SelectAnotherProductInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAnotherProductInfoButton.Name = "SelectAnotherProductInfoButton";
            this.SelectAnotherProductInfoButton.Size = new System.Drawing.Size(280, 40);
            this.SelectAnotherProductInfoButton.TabIndex = 7;
            this.SelectAnotherProductInfoButton.Text = "Select Another Product";
            this.SelectAnotherProductInfoButton.UseVisualStyleBackColor = true;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.SelectAnotherProductInfoButton);
            this.Controls.Add(this.NextProductInfoButton);
            this.Controls.Add(this.CancelProductInfoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextProductInfoButton;
        private System.Windows.Forms.Button CancelProductInfoButton;
        private System.Windows.Forms.Button SelectAnotherProductInfoButton;
    }
}