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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionOrderResultLabel.Text = Program.computers.Condition;
            PriceOrderResultLabel.Text = "$ " + Program.computers.Cost.ToString();
            PlatformOrderResultLabel.Text = Program.computers.Platform;
            OSOrderResultLabel.Text = Program.computers.OS;
            ManufacturerOrderResultLabel.Text = Program.computers.Manufacturer;
            ModelOrderResultLabel.Text = Program.computers.Model;
            MemoryOrderResultLabel.Text = Program.computers.RAMSize;
            LCDSizeOrderResultLabel.Text = Program.computers.ScreenSize;
            HDDOrderResultLabel.Text = Program.computers.HDDSize;
            CPUBrandOrderResultLabel.Text = Program.computers.CPUBrand;
            CPUNumberOrderResultLabel.Text = Program.computers.CPUNumber;
            GPUTypeOrderResultLabel.Text = Program.computers.GPUType;
            CPUTypeOrderResultLabel.Text = Program.computers.CPUType;
            CPUSpeedOrderResultLabel.Text = Program.computers.CPUSpeed;
            WebCamOrderResultLabel.Text = Program.computers.WebCam;
            OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\Assignment5\\Acer.jpg");
            OrderPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
