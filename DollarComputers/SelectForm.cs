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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.dollarComputersDataSet.products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SelectionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //aliases
            var rowIndex = SelectionDataGridView.CurrentCell.RowIndex;
            var rows = SelectionDataGridView.Rows;
            var cells = rows[rowIndex].Cells;
            var columnCount = SelectionDataGridView.ColumnCount;

            SelectionDataGridView.Rows[rowIndex].Selected = true;

            string outputString = string.Empty;
            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value.ToString() + " ";
            }

            SelectedItemTextBox.Text = outputString;

            Program.computers.ProductID = int.Parse(cells[(int)ComputersFields.PRODUCT_ID].Value.ToString());
            Program.computers.Cost = double.Parse(cells[(int)ComputersFields.COST].Value.ToString());
            Program.computers.Condition = cells[(int)ComputersFields.CONDITION].Value.ToString();
            Program.computers.Manufacturer = cells[(int)ComputersFields.MANUFACTURER].Value.ToString();
            Program.computers.Model = cells[(int)ComputersFields.MODEL].Value.ToString();
            Program.computers.RAMSize = cells[(int)ComputersFields.RAM_SIZE].Value.ToString();
            Program.computers.Platform = cells[(int)ComputersFields.PLATFORM].Value.ToString();
            Program.computers.OS = cells[(int)ComputersFields.OS].Value.ToString();
            Program.computers.RAMSize = cells[(int)ComputersFields.RAM_SIZE].Value.ToString();
            Program.computers.CPUNumber = cells[(int)ComputersFields.CPU_NUMBER].Value.ToString();
            Program.computers.ScreenSize = cells[(int)ComputersFields.SCREEN_SIZE].Value.ToString();
            Program.computers.HDDSize = cells[(int)ComputersFields.HDD_SIZE].Value.ToString();
            Program.computers.CPUBrand = cells[(int)ComputersFields.CPU_BRAND].Value.ToString();
            Program.computers.GPUType = cells[(int)ComputersFields.GPU_TYPE].Value.ToString();
            Program.computers.CPUType = cells[(int)ComputersFields.CPU_TYPE].Value.ToString();
            Program.computers.CPUSpeed = cells[(int)ComputersFields.CPU_SPEED].Value.ToString();
            Program.computers.WebCam = cells[(int)ComputersFields.WEBCAM].Value.ToString();
        }

        private void NextSelectButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void CancelSelectButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
