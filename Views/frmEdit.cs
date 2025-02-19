using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = ClosedXML.Excel;

namespace ScannerReader
{
    public partial class frmEdit : Form
    {
        private IEnumerable<Excel.IXLCell> Product;
        public frmEdit(IEnumerable<Excel.IXLCell> cell)
        {
            this.Product = cell;
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            Decimal money;
            int number;
            txtbCodigo.Text = Product.First().Value.ToString();
            txtbProductName.Text = Product.ElementAt(1).Value.ToString();
            txtbWeight.Text = Product.ElementAt(2).Value.ToString();
            nudStock.Value = int.TryParse(Product.ElementAt(3).Value.ToString(), out number) ? number : 0;
            nudBuyPrice.Value = Decimal.TryParse(Product.ElementAt(4).Value.ToString(), out money) ? money : (decimal)0.00;
            nudSellPrice.Value = Decimal.TryParse(Product.ElementAt(5).Value.ToString(), out money) ? money : (decimal)0.00;
            txtbProductName.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtbProductName.Text.Trim() != "")
            {
                var excelFile = new Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
                var excelSheet = excelFile.Worksheet("Productos");

                excelSheet.Cell(Product.ElementAt(1).Address).Value = txtbProductName.Text;
                excelSheet.Cell(Product.ElementAt(2).Address).Value = txtbWeight.Text;
                excelSheet.Cell(Product.ElementAt(3).Address).Value = nudStock.Value;
                excelSheet.Cell(Product.ElementAt(4).Address).Value = nudBuyPrice.Value;
                excelSheet.Cell(Product.ElementAt(5).Address).Value = nudSellPrice.Value;

                excelFile.Save();

                this.Dispose();
                this.Close();
            } else
            {
                MessageBox.Show("El nombre del producto no puede estar vacio.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
