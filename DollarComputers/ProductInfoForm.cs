using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Assignment 5 - COMP123 - Summer 2019
 * name: Lilian Nishimaru de Souza
 * id  : 301044056 
 * date: 07/24/2019   
 */
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

        private void SelectAnotherProductInfoButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

    private void SaveStripMenuItem_Click(object sender, EventArgs e)
    {
        //configuring the dialog
        ProductSaveFileDialog.FileName = "Product.txt";
        ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

        //open file dialog - Modal Form
        var result = ProductSaveFileDialog.ShowDialog();
        if (result != DialogResult.Cancel)
        {
            //open file
            using (StreamWriter outputString = new StreamWriter(
                File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
            {
                //write file
                outputString.WriteLine(Program.computers.ProductID);
                outputString.WriteLine(Program.computers.Cost.ToString());
                outputString.WriteLine(Program.computers.Condition);
                outputString.WriteLine(Program.computers.Platform);
                outputString.WriteLine(Program.computers.OS);
                outputString.WriteLine(Program.computers.Manufacturer);
                outputString.WriteLine(Program.computers.Model);
                outputString.WriteLine(Program.computers.RAMSize);
                outputString.WriteLine(Program.computers.ScreenSize);
                outputString.WriteLine(Program.computers.HDDSize);
                outputString.WriteLine(Program.computers.CPUBrand);
                outputString.WriteLine(Program.computers.CPUNumber);
                outputString.WriteLine(Program.computers.GPUType);
                outputString.WriteLine(Program.computers.CPUType);
                outputString.WriteLine(Program.computers.CPUSpeed);
                outputString.WriteLine(Program.computers.WebCam);

                //close file
                outputString.Close();

                //dispose of the memory
                outputString.Dispose();
            }
            MessageBox.Show("File Saved", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

        private void OpenStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure open file dialog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputStream = new StreamReader(
                File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                {
                    try
                    {
                        //read file

                        Program.computers.ProductID = int.Parse(inputStream.ReadLine());
                        Program.computers.Cost = double.Parse(inputStream.ReadLine());
                        Program.computers.Condition = inputStream.ReadLine();
                        Program.computers.Platform = inputStream.ReadLine();
                        Program.computers.OS = inputStream.ReadLine();
                        Program.computers.Manufacturer = inputStream.ReadLine();
                        Program.computers.Model = inputStream.ReadLine();
                        Program.computers.RAMSize = inputStream.ReadLine();
                        Program.computers.ScreenSize = inputStream.ReadLine();
                        Program.computers.HDDSize = inputStream.ReadLine();
                        Program.computers.CPUBrand = inputStream.ReadLine();
                        Program.computers.CPUNumber = inputStream.ReadLine();
                        Program.computers.GPUType = inputStream.ReadLine();
                        Program.computers.CPUType = inputStream.ReadLine();
                        Program.computers.CPUSpeed = inputStream.ReadLine();
                        Program.computers.WebCam = inputStream.ReadLine();

                        inputStream.Close();
                        inputStream.Dispose();

                        ProductInfoForm_Activated(sender, e);
                    }
                    catch (IOException exception)
                    {
                        MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
