using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Presentation;
using ScannerReader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Excel = ClosedXML.Excel;

namespace ScannerReader.Views
{
    public partial class FrmSell : Form
    {
        private TableLayoutPanel MainPanel;
        private PictureBox Camera;
        public FrmSell(PictureBox camera, TableLayoutPanel mainPanel)
        {
            this.MainPanel = mainPanel;
            this.Camera = camera;
            InitializeComponent();
            MainPanel.Controls[0].Select();
        }

        private void frmSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPanel.Controls[2].Visible = true;
        }

        public void AddProduct(Product item, int quantity)
        {
            double sellPrice;
            if (item.SellPriceInputType == SellPriceCalcStyle.Porcent)
            {
                sellPrice = quantity * (item.BuyPrice + (item.BuyPrice / 100 * item.SellPrice));
            }
            else
            {
                sellPrice = quantity * item.SellPrice;
            }
            dgvProductTable.Rows.Add(quantity, item.Name, item.Variant, sellPrice);
            TotalSellRevaluate();
            nudQuantity.Value = 1;
        }

        private void dgvProductTable_SelectionChanged(object sender, EventArgs e)
        {
            if((dgvProductTable.Rows.Count > 0) && (dgvProductTable.SelectedRows.Count > 0) && (dgvProductTable.SelectedRows[0].Cells[0].Value != null)) nudQuantity.Value = int.Parse(dgvProductTable.SelectedRows[0].Cells[0].Value.ToString()); 
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if ((dgvProductTable.SelectedRows.Count > 0) && (dgvProductTable.SelectedRows[0].Cells[0].Value != null))
            {
                double unit = double.Parse(dgvProductTable.SelectedRows[0].Cells[3].Value.ToString()) / double.Parse(dgvProductTable.SelectedRows[0].Cells[0].Value.ToString());
                dgvProductTable.SelectedRows[0].Cells[0].Value = nudQuantity.Value;
                dgvProductTable.SelectedRows[0].Cells[3].Value = ((int)nudQuantity.Value)*unit;
            }
        }

        private void dgvProductTable_CellValueChanged(object sender, DataGridViewCellEventArgs e) => TotalSellRevaluate();

        private void TotalSellRevaluate()
        {
            nudTotalSell.Value = 0;
            for (int i = 0; i < dgvProductTable.Rows.Count; i++)
            {
                if (dgvProductTable.Rows[i].Cells[3].Value != null)
                {
                    nudTotalSell.Value += decimal.Parse(dgvProductTable.Rows[i].Cells[3].Value.ToString());
                }
            }
            nudTotalSell.Value = Math.Round(nudTotalSell.Value);
            MainPanel.Controls[0].Select();
        }

        private void nudTotalSell_Paint(object sender, PaintEventArgs e)
        {
            NumericUpDown obj = (NumericUpDown)sender;

            obj.Controls[0].Visible = false;
            obj.Controls[0].BackColor = Color.Chocolate;
        }

        private void dgvProductTable_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (!dgvProductTable.SelectedRows[0].IsNewRow))
            {
                if (dgvProductTable.Rows.Count > 0)
                {
                    dgvProductTable.Rows.Remove(dgvProductTable.SelectedRows[0]);
                    MainPanel.Controls[0].Select();
                }
                TotalSellRevaluate();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvProductTable.Rows.Clear();
            TotalSellRevaluate();
            nudQuantity.Value = 1;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dgvProductTable.Rows.Count < 2)
            {
                MessageBox.Show("No hay ningún producto en la lista de venta");
            } else
            {
                var excelFile = new Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
                var sheetSales = excelFile.Worksheets.Worksheet("Ventas");
                var sheetProducts = excelFile.Worksheets.Worksheet("Productos");
                var products = dgvProductTable.Rows;
                int idVenta;
                int cell = int.Parse(sheetSales.Column("A").LastCellUsed().CellBelow().ToString().Substring(1));

                if (sheetSales.Cell("A2").IsEmpty())
                {
                    idVenta = 1;
                }
                else
                {
                    idVenta = (int)sheetSales.Column("A").LastCellUsed().Value + 1;
                }

                foreach (DataGridViewRow product in products)
                {
                    if (product.IsNewRow) continue;
                    IXLCell cellProduct = sheetProducts.Column("B").CellsUsed().FirstOrDefault(cellp => cellp.Value.ToString() == product.Cells[1].Value.ToString() && cellp.Address.ToString() != "B1");

                    if(cellProduct != null)
                    {
                        string row = cellProduct.Address.RowNumber.ToString();
                        sheetProducts.Cell($"D{row}").Value = int.Parse(sheetProducts.Cell($"D{row}").Value.ToString()) - int.Parse(product.Cells[0].Value.ToString());
                    }

                    sheetSales.Cell("A" + cell.ToString()).Value = idVenta;
                    sheetSales.Cell("B" + cell.ToString()).Value = int.Parse(product.Cells[0].Value.ToString());
                    sheetSales.Cell("C" + cell.ToString()).Value = product.Cells[1].Value.ToString();
                    sheetSales.Cell("D" + cell.ToString()).Value = product.Cells[2].Value.ToString();
                    sheetSales.Cell("E" + cell.ToString()).Value = (double)product.Cells[3].Value;
                    sheetSales.Cell("F" + cell.ToString()).Value = DateTime.Now.ToLocalTime().ToString();
                    sheetSales.Cell("G" + cell.ToString()).FormulaA1 = ($"IFERROR((E{cell}-(INDEX(PRODUCTOS.$E$2:E$500,MATCH(1, (TEXT(PRODUCTOS.$B$2:$B$500, \"@\") = TEXT(C{cell}, \"@\")) * (TEXT(PRODUCTOS.$C$2:$C$500, \"@\") = TEXT(D{cell}, \"@\")), 0))*B{cell})),0)");
                    cell++;
                }
                excelFile.Save();
                Console.Beep();
                dgvProductTable.Rows.Clear();
                nudQuantity.Value = 1;
                nudTotalSell.Value = 0;
            }
            MainPanel.Controls[0].Select();
        }

        private void btnAddKilogramProduct_Click(object sender, EventArgs e)
        {
            frmKilogramProduct frmKilogramProduct = new frmKilogramProduct(this);
            frmKilogramProduct.ShowDialog();
            frmKilogramProduct.BringToFront();
        }

        private void dgvProductTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TotalSellRevaluate();
        }
    }
}
