using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Assignment 5 - COMP123 - Summer 2019
 * name: Lilian Nishimaru de Souza
 * id  : 301044056 
 * date: 07/24/2019   
 */
namespace DollarComputers
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method handles the event of clicking the Cancel button
        /// and the Tool Strip Exit option on Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This event handles the event of clicking the Back button and 
        /// the Back menu on Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This method assigns the values on the computer's class to the Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            LoadImage(Program.computers.Manufacturer.Trim());
            double tax = Math.Round(Program.computers.Cost * 0.13,2);
            TaxOrderResultLabel.Text = "$ " + tax.ToString("#.00");
            double total = Program.computers.Cost + tax;
            TotalOrderResultLabel.Text = "$ " + total.ToString("#.00");

        }
        /// <summary>
        /// This method assigns the images from each hardware to the order form
        /// </summary>
        /// <param name="manufacturer"></param>
        private void LoadImage(string manufacturer)
        {
            switch (manufacturer.ToUpper())
            {
                case "ACER":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Acer.jpg");
                    break;
                case "Asus":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Asus.jpg");
                    break;
                case "CYBERTRONPC":
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
                case "APPLE":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\imac.jpg");
                    break;
                case "LENOVO":
                    OrderPicture.Image = Image.FromFile("C:\\Users\\Lillis\\Documents\\Centennial\\COMP123\\DollarComputers\\DollarComputers\\images\\Lenovo.jpg");
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
        /// <summary>
        /// This method opens the print options dialog on Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            OrderPrintForm.Print();
        }
        /// <summary>
        /// This event handles the Finish button on Order Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult buttonResult = MessageBox.Show("Thank you for shopping with us! \n\nYour order will be processed in 7-10 bussiness days.","Order Confirmed", MessageBoxButtons.OK);
            if (buttonResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
