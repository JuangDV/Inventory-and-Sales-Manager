using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = ClosedXML.Excel;

namespace ScannerReader
{
    public partial class frmAgregar : Form
    {
        private string Code;
        public frmAgregar(string code)
        {
            this.Code = code;
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            txtbCodigo.Text = Code;
            txtbProductName.Select();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtbProductName.Text != "")
            {
                var excelFile = new Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
                var excelSheet = excelFile.Worksheets.Worksheet("Productos");

                var cell = excelSheet.Column("A").LastCellUsed().CellBelow().ToString().Substring(1);

                excelSheet.Cell("A" + cell).Value = txtbCodigo.Text;
                excelSheet.Cell("B" + cell).Value = txtbProductName.Text;
                excelSheet.Cell("C" + cell).Value = txtbWeight.Text;
                excelSheet.Cell("D" + cell).Value = nudStock.Text;
                excelSheet.Cell("E" + cell).Value = nudBuyPrice.Text;
                excelSheet.Cell("F" + cell).Value = nudSellPrice.Text;

                excelFile.Save();
            } else
            {
                MessageBox.Show("No se ha ingresado un nombre");
            }

            MessageBox.Show("Producto guardado.");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
