using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerReader.Views
{
    public partial class frmKilogramProduct : Form
    {
        private FrmSell FrmSell;
        public frmKilogramProduct(FrmSell frmSell)
        {
            InitializeComponent();
            this.FrmSell = frmSell;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if(txtbProductName.Text.Trim() != "")
            {
                if(nudProductGrams.Value > 0)
                {
                    if(nudProductPrice.Value > 0)
                    {
                        DataGridView table = (DataGridView)FrmSell.Controls.Find("dgvProductTable", true).First();
                        table.Rows.Add(nudProductGrams.Value, txtbProductName.Text, "", (double)nudProductPrice.Value);
                        this.Close();
                    } else
                    {
                        errorMessage += "El precio debe ser mayor a 0\n";
                    }
                } else
                {
                    errorMessage += "Los gramos deben ser mayor a 0\n";
                }
            } else
            {
                errorMessage += "El nombre es invalido\n";
            }
            if(errorMessage != "") MessageBox.Show(errorMessage, "Error de carga", MessageBoxButtons.OK);
        }
    }
}
