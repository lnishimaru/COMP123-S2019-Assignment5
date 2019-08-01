using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDResultLabel.Text = Program.computers.ProductID.ToString();
            ConditionResultLabel.Text = Program.computers.Condition;
            CostResultLabel.Text = "$ " + Program.computers.Cost.ToString();
            PlatformResultLabel.Text = Program.computers.Platform;
            OSResultLabel.Text = Program.computers.OS;
            ManufacturerResultLabel.Text = Program.computers.Manufacturer;
            ModelResultLabel.Text = Program.computers.Model;
            MemoryResultLabel.Text = Program.computers.RAMSize;
            LCDSizeResultLabel.Text = Program.computers.ScreenSize;
            HDDResultLabel.Text = Program.computers.HDDSize;
            CPUBrandResultLabel.Text = Program.computers.CPUBrand;
            CPUNumberResultLabel.Text = Program.computers.CPUNumber;
            GPUTypeResultLabel.Text = Program.computers.GPUType;
            CPUTypeResultLabel.Text = Program.computers.CPUType;
            CPUSpeedResultLabel.Text = Program.computers.CPUSpeed;
            WebCamResultLabel.Text = Program.computers.WebCam;
        }

        private void CancelProductInfoButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextProductInfoButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }
    }
}
