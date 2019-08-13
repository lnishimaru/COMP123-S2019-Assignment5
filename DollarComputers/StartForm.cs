using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        private void OpenSavedOrder_Click(object sender, EventArgs e)
        {
            //configure open file dialog
            OpenFileDialog.FileName = "Product.txt";
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = OpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputStream = new StreamReader(
                File.Open(OpenFileDialog.FileName, FileMode.Open)))
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

                        Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
                        this.Hide();
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
