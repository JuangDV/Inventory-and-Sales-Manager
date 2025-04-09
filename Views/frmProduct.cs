using ScannerReader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerReader.Views
{
    public partial class frmProduct : Form
    {
        private Product Product = new Product();
        public frmProduct(Product product)
        {
            InitializeComponent();
            LoadProduct(product);
            Product = product;
        }
        public frmProduct(string result)
        {
            InitializeComponent();
            if(Product.Find(result).Id == null )
            {
                txtbProductId.Text = result;
            } else
            {
                Product = Product.Find(result);
                LoadProduct(Product);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product.Id = txtbProductId.Text;
            Product.Name = txtbProductName.Text;
            Product.Variant = txtbProductVariant.Text;

            if (rbStockAdd.Checked)
            {
                Product.Stock += (double)nudProductStock.Value;
            }
            else if (rbStockSub.Checked)
            {
                Product.Stock -= (double)nudProductStock.Value;
            }
            else
            {
                Product.Stock = (double)nudProductStock.Value;
            }

            Product.BuyPrice = (double)nudProductBuyPrice.Value;
            Product.SellPrice = (double)nudProductSellPrice.Value;
            if (rbSellPricePorcent.Checked)
            {
                Product.SellPriceInputType = SellPriceCalcStyle.Porcent;
            } else
            {
                Product.SellPriceInputType = SellPriceCalcStyle.Manual;
            }

            bool productSavedStatus = Product.Find(Product.Id).Id == null ? Product.Add() : Product.Update(Product);

            if (productSavedStatus == true)
            {
                MessageBox.Show($"El producto {Product.Id} se ha guardado exitosamente", "Producto guardado exitosamente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduct(Product);
            }
            else
            {
                MessageBox.Show($"El producto {Product.Id} no se ha podido guardar", "Error al guardar el producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadProduct(Product product)
        {
            txtbProductId.Text = product.Id;
            txtbProductName.Text = product.Name;
            txtbProductVariant.Text = product.Variant;
            nudProductStock.Value = product.Stock < 0 ? 0: (decimal)product.Stock;
            nudProductBuyPrice.Value = (decimal)product.BuyPrice;
            nudProductSellPrice.Value = (decimal)product.SellPrice;
            if (product.SellPriceInputType == SellPriceCalcStyle.Porcent) rbSellPricePorcent.Checked = true;

            txtbProductName.Enabled = false;
            txtbProductVariant.Enabled = false;
            nudProductStock.Enabled = false;
            nudProductBuyPrice.Enabled = false;
            nudProductSellPrice.Enabled = false;
            flpStockInputType.Visible = false;
            flpSellPriceInputType.Enabled = false;
            btnSaveProduct.Visible = false;
            btnEditProduct.Visible = true;
        }

        private void EditProduct()
        {
            txtbProductName.Enabled = true;
            txtbProductVariant.Enabled = true;
            nudProductStock.Enabled = true;
            nudProductBuyPrice.Enabled = true;
            nudProductSellPrice.Enabled = true;
            flpStockInputType.Visible = true;
            flpSellPriceInputType.Enabled = true;
            btnSaveProduct.Visible = true;
            btnEditProduct.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
        }
    }
}
