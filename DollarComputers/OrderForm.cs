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
            PriceOrderResultLabel.Text = "$ " + Program.computers.Cost.ToString("#.00");
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
            LoadImage(Program.computers.Manufacturer);
            double tax = Math.Round(Program.computers.Cost * 0.13,2);
            TaxOrderResultLabel.Text = "$ " + tax.ToString("#.00");
            double total = Program.computers.Cost + tax;
            TotalOrderResultLabel.Text = "$ " + total.ToString("#.00");

        }

        private void LoadImage(string manufacturer)
        {
            //string test = manufacturer.ToUpper();
            
            switch (manufacturer)
            {
                case "ACER":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Acer.jpg");
                    break;
                case "Asus":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Asus.jpg");
                    break;
                case "CYBERTRON":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Cybertron.jpg");
                    break;
                case "GATEWAY":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Gateway.jpg");
                    break;
                case "HP":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\HP.jpg");
                    break;
                case "IBUYPOWER":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Ibuypower.jpg");
                    break;
                case "IMAC":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\imac.jpg");
                    break;
                case "LENOVO":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Lenovo.jpg");
                    break;
                case "MACPRO":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\MacPro.png");
                    break;
                case "TOSHIBA":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Toshiba.JPG");
                    break;
                default:
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\dollarLogo.png");
                    break;
            }
            OrderPicture.SizeMode = PictureBoxSizeMode.StretchImage; 
        } 

        /// <summary>
        /// Event Handler to the About Strip Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            OrderPrintForm.Print();
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult buttonResult = MessageBox.Show("Thank you for purchasing at Dollar Computers! \n\nYour order will be processed in 7-10 bussiness days.","Place Order", MessageBoxButtons.OK);
            if (buttonResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
