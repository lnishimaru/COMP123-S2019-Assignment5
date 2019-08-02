namespace DollarComputers
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
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OSOrderResultLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.LCDSizeOrderResultLabel = new System.Windows.Forms.Label();
            this.MemoryOrderResultLabel = new System.Windows.Forms.Label();
            this.CPUBrandOrderResultLabel = new System.Windows.Forms.Label();
            this.CPUTypeOrderResultLabel = new System.Windows.Forms.Label();
            this.CPUNumberOrderResultLabel = new System.Windows.Forms.Label();
            this.HDDOrderResultLabel = new System.Windows.Forms.Label();
            this.CPUSpeedOrderResultLabel = new System.Windows.Forms.Label();
            this.GPUTypeOrderResultLabel = new System.Windows.Forms.Label();
            this.WebCamOrderResultLabel = new System.Windows.Forms.Label();
            this.ProductInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ModelOrderResultLabel = new System.Windows.Forms.Label();
            this.ConditionLabelOrderForm = new System.Windows.Forms.Label();
            this.ManufacturerOrderLabel = new System.Windows.Forms.Label();
            this.ConditionOrderResultLabel = new System.Windows.Forms.Label();
            this.ManufacturerOrderResultLabel = new System.Windows.Forms.Label();
            this.ModelOrderLabel = new System.Windows.Forms.Label();
            this.PlatformOrderLabel = new System.Windows.Forms.Label();
            this.PlatformOrderResultLabel = new System.Windows.Forms.Label();
            this.OrderPicture = new System.Windows.Forms.PictureBox();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TotalOrderResultLabel = new System.Windows.Forms.Label();
            this.TotalOrderLabel = new System.Windows.Forms.Label();
            this.PriceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TaxOrderResultLabel = new System.Windows.Forms.Label();
            this.PriceOrderResultLabel = new System.Windows.Forms.Label();
            this.PriceOrderLabel = new System.Windows.Forms.Label();
            this.TaxOrderLabel = new System.Windows.Forms.Label();
            this.OrderMenuStrip.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.OrderTableLayoutPanel.SuspendLayout();
            this.ProductInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).BeginInit();
            this.YourPriceGroupBox.SuspendLayout();
            this.TotalTableLayoutPanel.SuspendLayout();
            this.PriceTableLayoutPanel.SuspendLayout();
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
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(1006, 28);
            this.OrderMenuStrip.TabIndex = 10;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackOrderButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.OrderTableLayoutPanel);
            this.OrderGroupBox.Controls.Add(this.ProductInfoTableLayoutPanel);
            this.OrderGroupBox.Location = new System.Drawing.Point(12, 57);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(658, 523);
            this.OrderGroupBox.TabIndex = 11;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "System Components";
            // 
            // OrderTableLayoutPanel
            // 
            this.OrderTableLayoutPanel.ColumnCount = 2;
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderTableLayoutPanel.Controls.Add(this.OSOrderResultLabel, 1, 9);
            this.OrderTableLayoutPanel.Controls.Add(this.OSLabel, 0, 9);
            this.OrderTableLayoutPanel.Controls.Add(this.LCDSizeLabel, 0, 0);
            this.OrderTableLayoutPanel.Controls.Add(this.MemoryLabel, 0, 1);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUBrandLabel, 0, 2);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUTypeLabel, 0, 3);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUNumberLabel, 0, 4);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUSpeedLabel, 0, 5);
            this.OrderTableLayoutPanel.Controls.Add(this.HDDLabel, 0, 6);
            this.OrderTableLayoutPanel.Controls.Add(this.GPUTypeLabel, 0, 7);
            this.OrderTableLayoutPanel.Controls.Add(this.WebCamLabel, 0, 8);
            this.OrderTableLayoutPanel.Controls.Add(this.LCDSizeOrderResultLabel, 1, 0);
            this.OrderTableLayoutPanel.Controls.Add(this.MemoryOrderResultLabel, 1, 1);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUBrandOrderResultLabel, 1, 2);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUTypeOrderResultLabel, 1, 3);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUNumberOrderResultLabel, 1, 4);
            this.OrderTableLayoutPanel.Controls.Add(this.HDDOrderResultLabel, 1, 6);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUSpeedOrderResultLabel, 1, 5);
            this.OrderTableLayoutPanel.Controls.Add(this.GPUTypeOrderResultLabel, 1, 7);
            this.OrderTableLayoutPanel.Controls.Add(this.WebCamOrderResultLabel, 1, 8);
            this.OrderTableLayoutPanel.Location = new System.Drawing.Point(8, 195);
            this.OrderTableLayoutPanel.Name = "OrderTableLayoutPanel";
            this.OrderTableLayoutPanel.RowCount = 10;
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.Size = new System.Drawing.Size(641, 274);
            this.OrderTableLayoutPanel.TabIndex = 14;
            // 
            // OSOrderResultLabel
            // 
            this.OSOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.OSOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OSOrderResultLabel.Location = new System.Drawing.Point(165, 243);
            this.OSOrderResultLabel.Name = "OSOrderResultLabel";
            this.OSOrderResultLabel.Size = new System.Drawing.Size(473, 31);
            this.OSOrderResultLabel.TabIndex = 22;
            this.OSOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            this.OSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(3, 243);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(156, 31);
            this.OSLabel.TabIndex = 16;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(3, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(156, 27);
            this.LCDSizeLabel.TabIndex = 7;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(3, 27);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(156, 27);
            this.MemoryLabel.TabIndex = 8;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 54);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(156, 27);
            this.CPUBrandLabel.TabIndex = 9;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 81);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(156, 27);
            this.CPUTypeLabel.TabIndex = 10;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 108);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(156, 27);
            this.CPUNumberLabel.TabIndex = 11;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 135);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(156, 27);
            this.CPUSpeedLabel.TabIndex = 12;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(3, 162);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(156, 27);
            this.HDDLabel.TabIndex = 13;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(3, 189);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(156, 27);
            this.GPUTypeLabel.TabIndex = 14;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(3, 216);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(156, 27);
            this.WebCamLabel.TabIndex = 15;
            this.WebCamLabel.Text = "Web Cam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeOrderResultLabel
            // 
            this.LCDSizeOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LCDSizeOrderResultLabel.Location = new System.Drawing.Point(165, 0);
            this.LCDSizeOrderResultLabel.Name = "LCDSizeOrderResultLabel";
            this.LCDSizeOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.LCDSizeOrderResultLabel.TabIndex = 17;
            this.LCDSizeOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryOrderResultLabel
            // 
            this.MemoryOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.MemoryOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MemoryOrderResultLabel.Location = new System.Drawing.Point(165, 27);
            this.MemoryOrderResultLabel.Name = "MemoryOrderResultLabel";
            this.MemoryOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.MemoryOrderResultLabel.TabIndex = 18;
            this.MemoryOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandOrderResultLabel
            // 
            this.CPUBrandOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUBrandOrderResultLabel.Location = new System.Drawing.Point(165, 54);
            this.CPUBrandOrderResultLabel.Name = "CPUBrandOrderResultLabel";
            this.CPUBrandOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.CPUBrandOrderResultLabel.TabIndex = 19;
            this.CPUBrandOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeOrderResultLabel
            // 
            this.CPUTypeOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUTypeOrderResultLabel.Location = new System.Drawing.Point(165, 81);
            this.CPUTypeOrderResultLabel.Name = "CPUTypeOrderResultLabel";
            this.CPUTypeOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.CPUTypeOrderResultLabel.TabIndex = 20;
            this.CPUTypeOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberOrderResultLabel
            // 
            this.CPUNumberOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUNumberOrderResultLabel.Location = new System.Drawing.Point(165, 108);
            this.CPUNumberOrderResultLabel.Name = "CPUNumberOrderResultLabel";
            this.CPUNumberOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.CPUNumberOrderResultLabel.TabIndex = 21;
            this.CPUNumberOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDOrderResultLabel
            // 
            this.HDDOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.HDDOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HDDOrderResultLabel.Location = new System.Drawing.Point(165, 162);
            this.HDDOrderResultLabel.Name = "HDDOrderResultLabel";
            this.HDDOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.HDDOrderResultLabel.TabIndex = 22;
            this.HDDOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedOrderResultLabel
            // 
            this.CPUSpeedOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUSpeedOrderResultLabel.Location = new System.Drawing.Point(165, 135);
            this.CPUSpeedOrderResultLabel.Name = "CPUSpeedOrderResultLabel";
            this.CPUSpeedOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.CPUSpeedOrderResultLabel.TabIndex = 23;
            this.CPUSpeedOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeOrderResultLabel
            // 
            this.GPUTypeOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GPUTypeOrderResultLabel.Location = new System.Drawing.Point(165, 189);
            this.GPUTypeOrderResultLabel.Name = "GPUTypeOrderResultLabel";
            this.GPUTypeOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.GPUTypeOrderResultLabel.TabIndex = 24;
            this.GPUTypeOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebCamOrderResultLabel
            // 
            this.WebCamOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebCamOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.WebCamOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WebCamOrderResultLabel.Location = new System.Drawing.Point(165, 216);
            this.WebCamOrderResultLabel.Name = "WebCamOrderResultLabel";
            this.WebCamOrderResultLabel.Size = new System.Drawing.Size(473, 27);
            this.WebCamOrderResultLabel.TabIndex = 25;
            this.WebCamOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductInfoTableLayoutPanel
            // 
            this.ProductInfoTableLayoutPanel.ColumnCount = 4;
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.84472F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63975F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77019F));
            this.ProductInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.59006F));
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ModelOrderResultLabel, 3, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ConditionLabelOrderForm, 0, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ManufacturerOrderLabel, 0, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ConditionOrderResultLabel, 1, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ManufacturerOrderResultLabel, 1, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.ModelOrderLabel, 2, 1);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.PlatformOrderLabel, 2, 0);
            this.ProductInfoTableLayoutPanel.Controls.Add(this.PlatformOrderResultLabel, 3, 0);
            this.ProductInfoTableLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.ProductInfoTableLayoutPanel.Name = "ProductInfoTableLayoutPanel";
            this.ProductInfoTableLayoutPanel.RowCount = 2;
            this.ProductInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ProductInfoTableLayoutPanel.Size = new System.Drawing.Size(644, 100);
            this.ProductInfoTableLayoutPanel.TabIndex = 13;
            // 
            // ModelOrderResultLabel
            // 
            this.ModelOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.ModelOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModelOrderResultLabel.Location = new System.Drawing.Point(449, 60);
            this.ModelOrderResultLabel.Name = "ModelOrderResultLabel";
            this.ModelOrderResultLabel.Size = new System.Drawing.Size(192, 29);
            this.ModelOrderResultLabel.TabIndex = 11;
            this.ModelOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabelOrderForm
            // 
            this.ConditionLabelOrderForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionLabelOrderForm.AutoSize = true;
            this.ConditionLabelOrderForm.Location = new System.Drawing.Point(3, 0);
            this.ConditionLabelOrderForm.Name = "ConditionLabelOrderForm";
            this.ConditionLabelOrderForm.Size = new System.Drawing.Size(154, 50);
            this.ConditionLabelOrderForm.TabIndex = 6;
            this.ConditionLabelOrderForm.Text = "Condition";
            this.ConditionLabelOrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerOrderLabel
            // 
            this.ManufacturerOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerOrderLabel.AutoSize = true;
            this.ManufacturerOrderLabel.Location = new System.Drawing.Point(3, 50);
            this.ManufacturerOrderLabel.Name = "ManufacturerOrderLabel";
            this.ManufacturerOrderLabel.Size = new System.Drawing.Size(154, 50);
            this.ManufacturerOrderLabel.TabIndex = 8;
            this.ManufacturerOrderLabel.Text = "Manufacturer";
            this.ManufacturerOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionOrderResultLabel
            // 
            this.ConditionOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.ConditionOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConditionOrderResultLabel.Location = new System.Drawing.Point(163, 10);
            this.ConditionOrderResultLabel.Name = "ConditionOrderResultLabel";
            this.ConditionOrderResultLabel.Size = new System.Drawing.Size(172, 29);
            this.ConditionOrderResultLabel.TabIndex = 7;
            this.ConditionOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerOrderResultLabel
            // 
            this.ManufacturerOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManufacturerOrderResultLabel.Location = new System.Drawing.Point(163, 60);
            this.ManufacturerOrderResultLabel.Name = "ManufacturerOrderResultLabel";
            this.ManufacturerOrderResultLabel.Size = new System.Drawing.Size(172, 29);
            this.ManufacturerOrderResultLabel.TabIndex = 9;
            this.ManufacturerOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelOrderLabel
            // 
            this.ModelOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelOrderLabel.AutoSize = true;
            this.ModelOrderLabel.Location = new System.Drawing.Point(341, 50);
            this.ModelOrderLabel.Name = "ModelOrderLabel";
            this.ModelOrderLabel.Size = new System.Drawing.Size(102, 50);
            this.ModelOrderLabel.TabIndex = 10;
            this.ModelOrderLabel.Text = "Model";
            this.ModelOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformOrderLabel
            // 
            this.PlatformOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformOrderLabel.AutoSize = true;
            this.PlatformOrderLabel.Location = new System.Drawing.Point(341, 0);
            this.PlatformOrderLabel.Name = "PlatformOrderLabel";
            this.PlatformOrderLabel.Size = new System.Drawing.Size(102, 50);
            this.PlatformOrderLabel.TabIndex = 4;
            this.PlatformOrderLabel.Text = "Platform";
            this.PlatformOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformOrderResultLabel
            // 
            this.PlatformOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.PlatformOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PlatformOrderResultLabel.Location = new System.Drawing.Point(449, 10);
            this.PlatformOrderResultLabel.Name = "PlatformOrderResultLabel";
            this.PlatformOrderResultLabel.Size = new System.Drawing.Size(192, 29);
            this.PlatformOrderResultLabel.TabIndex = 5;
            this.PlatformOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderPicture
            // 
            this.OrderPicture.Location = new System.Drawing.Point(740, 72);
            this.OrderPicture.Name = "OrderPicture";
            this.OrderPicture.Size = new System.Drawing.Size(200, 135);
            this.OrderPicture.TabIndex = 12;
            this.OrderPicture.TabStop = false;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalTableLayoutPanel);
            this.YourPriceGroupBox.Controls.Add(this.PriceTableLayoutPanel);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(689, 252);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(305, 274);
            this.YourPriceGroupBox.TabIndex = 13;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // TotalTableLayoutPanel
            // 
            this.TotalTableLayoutPanel.ColumnCount = 2;
            this.TotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TotalTableLayoutPanel.Controls.Add(this.TotalOrderResultLabel, 1, 0);
            this.TotalTableLayoutPanel.Controls.Add(this.TotalOrderLabel, 0, 0);
            this.TotalTableLayoutPanel.Location = new System.Drawing.Point(7, 189);
            this.TotalTableLayoutPanel.Name = "TotalTableLayoutPanel";
            this.TotalTableLayoutPanel.RowCount = 1;
            this.TotalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TotalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.TotalTableLayoutPanel.Size = new System.Drawing.Size(292, 54);
            this.TotalTableLayoutPanel.TabIndex = 12;
            // 
            // TotalOrderResultLabel
            // 
            this.TotalOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.TotalOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalOrderResultLabel.Location = new System.Drawing.Point(149, 12);
            this.TotalOrderResultLabel.Name = "TotalOrderResultLabel";
            this.TotalOrderResultLabel.Size = new System.Drawing.Size(140, 29);
            this.TotalOrderResultLabel.TabIndex = 14;
            this.TotalOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalOrderLabel
            // 
            this.TotalOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalOrderLabel.AutoSize = true;
            this.TotalOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.TotalOrderLabel.Name = "TotalOrderLabel";
            this.TotalOrderLabel.Size = new System.Drawing.Size(140, 54);
            this.TotalOrderLabel.TabIndex = 10;
            this.TotalOrderLabel.Text = "Total";
            this.TotalOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceTableLayoutPanel
            // 
            this.PriceTableLayoutPanel.ColumnCount = 2;
            this.PriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PriceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PriceTableLayoutPanel.Controls.Add(this.TaxOrderResultLabel, 1, 1);
            this.PriceTableLayoutPanel.Controls.Add(this.PriceOrderResultLabel, 1, 0);
            this.PriceTableLayoutPanel.Controls.Add(this.PriceOrderLabel, 0, 0);
            this.PriceTableLayoutPanel.Controls.Add(this.TaxOrderLabel, 0, 1);
            this.PriceTableLayoutPanel.Location = new System.Drawing.Point(6, 44);
            this.PriceTableLayoutPanel.Name = "PriceTableLayoutPanel";
            this.PriceTableLayoutPanel.RowCount = 2;
            this.PriceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PriceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PriceTableLayoutPanel.Size = new System.Drawing.Size(293, 100);
            this.PriceTableLayoutPanel.TabIndex = 11;
            // 
            // TaxOrderResultLabel
            // 
            this.TaxOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.TaxOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TaxOrderResultLabel.Location = new System.Drawing.Point(149, 60);
            this.TaxOrderResultLabel.Name = "TaxOrderResultLabel";
            this.TaxOrderResultLabel.Size = new System.Drawing.Size(141, 29);
            this.TaxOrderResultLabel.TabIndex = 13;
            this.TaxOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceOrderResultLabel
            // 
            this.PriceOrderResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceOrderResultLabel.BackColor = System.Drawing.Color.White;
            this.PriceOrderResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PriceOrderResultLabel.Location = new System.Drawing.Point(149, 10);
            this.PriceOrderResultLabel.Name = "PriceOrderResultLabel";
            this.PriceOrderResultLabel.Size = new System.Drawing.Size(141, 29);
            this.PriceOrderResultLabel.TabIndex = 12;
            this.PriceOrderResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceOrderLabel
            // 
            this.PriceOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceOrderLabel.AutoSize = true;
            this.PriceOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.PriceOrderLabel.Name = "PriceOrderLabel";
            this.PriceOrderLabel.Size = new System.Drawing.Size(140, 50);
            this.PriceOrderLabel.TabIndex = 8;
            this.PriceOrderLabel.Text = "Price";
            this.PriceOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaxOrderLabel
            // 
            this.TaxOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxOrderLabel.AutoSize = true;
            this.TaxOrderLabel.Location = new System.Drawing.Point(3, 50);
            this.TaxOrderLabel.Name = "TaxOrderLabel";
            this.TaxOrderLabel.Size = new System.Drawing.Size(140, 50);
            this.TaxOrderLabel.TabIndex = 9;
            this.TaxOrderLabel.Text = "Sales Tax (13%)";
            this.TaxOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 593);
            this.ControlBox = false;
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.OrderPicture);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.BackOrderButton);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete your Order";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderTableLayoutPanel.ResumeLayout(false);
            this.OrderTableLayoutPanel.PerformLayout();
            this.ProductInfoTableLayoutPanel.ResumeLayout(false);
            this.ProductInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).EndInit();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.TotalTableLayoutPanel.ResumeLayout(false);
            this.TotalTableLayoutPanel.PerformLayout();
            this.PriceTableLayoutPanel.ResumeLayout(false);
            this.PriceTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinishOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button BackOrderButton;
        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TableLayoutPanel OrderTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ProductInfoTableLayoutPanel;
        private System.Windows.Forms.Label ModelOrderResultLabel;
        private System.Windows.Forms.Label ConditionLabelOrderForm;
        private System.Windows.Forms.Label ManufacturerOrderLabel;
        private System.Windows.Forms.Label ConditionOrderResultLabel;
        private System.Windows.Forms.Label ManufacturerOrderResultLabel;
        private System.Windows.Forms.Label ModelOrderLabel;
        private System.Windows.Forms.Label PlatformOrderLabel;
        private System.Windows.Forms.Label PlatformOrderResultLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label LCDSizeOrderResultLabel;
        private System.Windows.Forms.Label MemoryOrderResultLabel;
        private System.Windows.Forms.Label CPUBrandOrderResultLabel;
        private System.Windows.Forms.Label OSOrderResultLabel;
        private System.Windows.Forms.Label CPUTypeOrderResultLabel;
        private System.Windows.Forms.Label CPUNumberOrderResultLabel;
        private System.Windows.Forms.Label HDDOrderResultLabel;
        private System.Windows.Forms.Label CPUSpeedOrderResultLabel;
        private System.Windows.Forms.Label GPUTypeOrderResultLabel;
        private System.Windows.Forms.Label WebCamOrderResultLabel;
        private System.Windows.Forms.PictureBox OrderPicture;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.TableLayoutPanel TotalTableLayoutPanel;
        private System.Windows.Forms.Label TotalOrderResultLabel;
        private System.Windows.Forms.Label TotalOrderLabel;
        private System.Windows.Forms.TableLayoutPanel PriceTableLayoutPanel;
        private System.Windows.Forms.Label TaxOrderResultLabel;
        private System.Windows.Forms.Label PriceOrderResultLabel;
        private System.Windows.Forms.Label PriceOrderLabel;
        private System.Windows.Forms.Label TaxOrderLabel;
    }
}