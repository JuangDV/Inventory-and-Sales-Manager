namespace ScannerReader.Views
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.lblProductId = new System.Windows.Forms.Label();
            this.flpSellPriceInputType = new System.Windows.Forms.FlowLayoutPanel();
            this.rbSellPriceManual = new System.Windows.Forms.RadioButton();
            this.rbSellPricePorcent = new System.Windows.Forms.RadioButton();
            this.nudProductSellPrice = new System.Windows.Forms.NumericUpDown();
            this.lblProductSellPrice = new System.Windows.Forms.Label();
            this.nudProductBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.lblProductBuyPrice = new System.Windows.Forms.Label();
            this.flpStockInputType = new System.Windows.Forms.FlowLayoutPanel();
            this.rbStockSet = new System.Windows.Forms.RadioButton();
            this.rbStockAdd = new System.Windows.Forms.RadioButton();
            this.rbStockSub = new System.Windows.Forms.RadioButton();
            this.nudProductStock = new System.Windows.Forms.NumericUpDown();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.lblProductVariant = new System.Windows.Forms.Label();
            this.txtbProductVariant = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtbProductName = new System.Windows.Forms.TextBox();
            this.txtbProductId = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.typMain.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.flpSellPriceInputType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductBuyPrice)).BeginInit();
            this.flpStockInputType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductStock)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typMain
            // 
            this.typMain.ColumnCount = 2;
            this.typMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typMain.Controls.Add(this.panelProduct, 0, 0);
            this.typMain.Controls.Add(this.btnClose, 1, 2);
            this.typMain.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.typMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.typMain.Location = new System.Drawing.Point(0, 0);
            this.typMain.Margin = new System.Windows.Forms.Padding(4);
            this.typMain.Name = "typMain";
            this.typMain.RowCount = 3;
            this.typMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.typMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.typMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.typMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.typMain.Size = new System.Drawing.Size(1250, 739);
            this.typMain.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.typMain.SetColumnSpan(this.panelProduct, 2);
            this.panelProduct.Controls.Add(this.lblProductId);
            this.panelProduct.Controls.Add(this.flpSellPriceInputType);
            this.panelProduct.Controls.Add(this.nudProductSellPrice);
            this.panelProduct.Controls.Add(this.lblProductSellPrice);
            this.panelProduct.Controls.Add(this.nudProductBuyPrice);
            this.panelProduct.Controls.Add(this.lblProductBuyPrice);
            this.panelProduct.Controls.Add(this.flpStockInputType);
            this.panelProduct.Controls.Add(this.nudProductStock);
            this.panelProduct.Controls.Add(this.lblProductStock);
            this.panelProduct.Controls.Add(this.lblProductVariant);
            this.panelProduct.Controls.Add(this.txtbProductVariant);
            this.panelProduct.Controls.Add(this.lblProductName);
            this.panelProduct.Controls.Add(this.txtbProductName);
            this.panelProduct.Controls.Add(this.txtbProductId);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(12, 13);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1226, 451);
            this.panelProduct.TabIndex = 0;
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductId.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductId.Location = new System.Drawing.Point(411, 30);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(72, 21);
            this.lblProductId.TabIndex = 17;
            this.lblProductId.Text = "Codigo";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpSellPriceInputType
            // 
            this.flpSellPriceInputType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpSellPriceInputType.AutoSize = true;
            this.flpSellPriceInputType.Controls.Add(this.rbSellPriceManual);
            this.flpSellPriceInputType.Controls.Add(this.rbSellPricePorcent);
            this.flpSellPriceInputType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flpSellPriceInputType.Location = new System.Drawing.Point(650, 207);
            this.flpSellPriceInputType.Margin = new System.Windows.Forms.Padding(4);
            this.flpSellPriceInputType.Name = "flpSellPriceInputType";
            this.flpSellPriceInputType.Size = new System.Drawing.Size(223, 35);
            this.flpSellPriceInputType.TabIndex = 16;
            // 
            // rbSellPriceManual
            // 
            this.rbSellPriceManual.AutoSize = true;
            this.rbSellPriceManual.Checked = true;
            this.rbSellPriceManual.Location = new System.Drawing.Point(4, 4);
            this.rbSellPriceManual.Margin = new System.Windows.Forms.Padding(4);
            this.rbSellPriceManual.Name = "rbSellPriceManual";
            this.rbSellPriceManual.Size = new System.Drawing.Size(90, 25);
            this.rbSellPriceManual.TabIndex = 8;
            this.rbSellPriceManual.TabStop = true;
            this.rbSellPriceManual.Text = "Manual";
            this.rbSellPriceManual.UseVisualStyleBackColor = true;
            // 
            // rbSellPricePorcent
            // 
            this.rbSellPricePorcent.AutoSize = true;
            this.rbSellPricePorcent.Location = new System.Drawing.Point(102, 4);
            this.rbSellPricePorcent.Margin = new System.Windows.Forms.Padding(4);
            this.rbSellPricePorcent.Name = "rbSellPricePorcent";
            this.rbSellPricePorcent.Size = new System.Drawing.Size(117, 25);
            this.rbSellPricePorcent.TabIndex = 9;
            this.rbSellPricePorcent.Text = "Porcentual";
            this.rbSellPricePorcent.UseVisualStyleBackColor = true;
            // 
            // nudProductSellPrice
            // 
            this.nudProductSellPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudProductSellPrice.DecimalPlaces = 2;
            this.nudProductSellPrice.Location = new System.Drawing.Point(492, 209);
            this.nudProductSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudProductSellPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudProductSellPrice.Name = "nudProductSellPrice";
            this.nudProductSellPrice.Size = new System.Drawing.Size(150, 28);
            this.nudProductSellPrice.TabIndex = 15;
            this.nudProductSellPrice.ThousandsSeparator = true;
            // 
            // lblProductSellPrice
            // 
            this.lblProductSellPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductSellPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSellPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductSellPrice.Location = new System.Drawing.Point(335, 211);
            this.lblProductSellPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductSellPrice.Name = "lblProductSellPrice";
            this.lblProductSellPrice.Size = new System.Drawing.Size(148, 21);
            this.lblProductSellPrice.TabIndex = 14;
            this.lblProductSellPrice.Text = "Precio de Venta";
            this.lblProductSellPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudProductBuyPrice
            // 
            this.nudProductBuyPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudProductBuyPrice.DecimalPlaces = 2;
            this.nudProductBuyPrice.Location = new System.Drawing.Point(492, 172);
            this.nudProductBuyPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudProductBuyPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudProductBuyPrice.Name = "nudProductBuyPrice";
            this.nudProductBuyPrice.Size = new System.Drawing.Size(150, 28);
            this.nudProductBuyPrice.TabIndex = 13;
            this.nudProductBuyPrice.ThousandsSeparator = true;
            // 
            // lblProductBuyPrice
            // 
            this.lblProductBuyPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductBuyPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBuyPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductBuyPrice.Location = new System.Drawing.Point(316, 174);
            this.lblProductBuyPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductBuyPrice.Name = "lblProductBuyPrice";
            this.lblProductBuyPrice.Size = new System.Drawing.Size(167, 21);
            this.lblProductBuyPrice.TabIndex = 12;
            this.lblProductBuyPrice.Text = "Precio de Compra";
            this.lblProductBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpStockInputType
            // 
            this.flpStockInputType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpStockInputType.AutoSize = true;
            this.flpStockInputType.Controls.Add(this.rbStockSet);
            this.flpStockInputType.Controls.Add(this.rbStockAdd);
            this.flpStockInputType.Controls.Add(this.rbStockSub);
            this.flpStockInputType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flpStockInputType.Location = new System.Drawing.Point(648, 134);
            this.flpStockInputType.Margin = new System.Windows.Forms.Padding(4);
            this.flpStockInputType.Name = "flpStockInputType";
            this.flpStockInputType.Size = new System.Drawing.Size(320, 35);
            this.flpStockInputType.TabIndex = 11;
            // 
            // rbStockSet
            // 
            this.rbStockSet.AutoSize = true;
            this.rbStockSet.Checked = true;
            this.rbStockSet.Location = new System.Drawing.Point(4, 4);
            this.rbStockSet.Margin = new System.Windows.Forms.Padding(4);
            this.rbStockSet.Name = "rbStockSet";
            this.rbStockSet.Size = new System.Drawing.Size(116, 25);
            this.rbStockSet.TabIndex = 8;
            this.rbStockSet.TabStop = true;
            this.rbStockSet.Text = "Establecer";
            this.rbStockSet.UseVisualStyleBackColor = true;
            // 
            // rbStockAdd
            // 
            this.rbStockAdd.AutoSize = true;
            this.rbStockAdd.Location = new System.Drawing.Point(128, 4);
            this.rbStockAdd.Margin = new System.Windows.Forms.Padding(4);
            this.rbStockAdd.Name = "rbStockAdd";
            this.rbStockAdd.Size = new System.Drawing.Size(94, 25);
            this.rbStockAdd.TabIndex = 9;
            this.rbStockAdd.Text = "Agregar";
            this.rbStockAdd.UseVisualStyleBackColor = true;
            // 
            // rbStockSub
            // 
            this.rbStockSub.AutoSize = true;
            this.rbStockSub.Location = new System.Drawing.Point(230, 4);
            this.rbStockSub.Margin = new System.Windows.Forms.Padding(4);
            this.rbStockSub.Name = "rbStockSub";
            this.rbStockSub.Size = new System.Drawing.Size(84, 25);
            this.rbStockSub.TabIndex = 10;
            this.rbStockSub.Text = "Restar";
            this.rbStockSub.UseVisualStyleBackColor = true;
            // 
            // nudProductStock
            // 
            this.nudProductStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudProductStock.Location = new System.Drawing.Point(491, 136);
            this.nudProductStock.Margin = new System.Windows.Forms.Padding(4);
            this.nudProductStock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudProductStock.Name = "nudProductStock";
            this.nudProductStock.Size = new System.Drawing.Size(150, 28);
            this.nudProductStock.TabIndex = 7;
            this.nudProductStock.ThousandsSeparator = true;
            // 
            // lblProductStock
            // 
            this.lblProductStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductStock.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductStock.Location = new System.Drawing.Point(424, 138);
            this.lblProductStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(59, 21);
            this.lblProductStock.TabIndex = 6;
            this.lblProductStock.Text = "Stock";
            this.lblProductStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductVariant
            // 
            this.lblProductVariant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductVariant.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductVariant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductVariant.Location = new System.Drawing.Point(401, 103);
            this.lblProductVariant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductVariant.Name = "lblProductVariant";
            this.lblProductVariant.Size = new System.Drawing.Size(82, 21);
            this.lblProductVariant.TabIndex = 4;
            this.lblProductVariant.Text = "Variante";
            this.lblProductVariant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbProductVariant
            // 
            this.txtbProductVariant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbProductVariant.Location = new System.Drawing.Point(491, 100);
            this.txtbProductVariant.Margin = new System.Windows.Forms.Padding(4);
            this.txtbProductVariant.Name = "txtbProductVariant";
            this.txtbProductVariant.Size = new System.Drawing.Size(242, 28);
            this.txtbProductVariant.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductName.Location = new System.Drawing.Point(403, 66);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(80, 21);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Nombre";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbProductName
            // 
            this.txtbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbProductName.Location = new System.Drawing.Point(491, 63);
            this.txtbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbProductName.Name = "txtbProductName";
            this.txtbProductName.Size = new System.Drawing.Size(242, 28);
            this.txtbProductName.TabIndex = 1;
            // 
            // txtbProductId
            // 
            this.txtbProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbProductId.Enabled = false;
            this.txtbProductId.Location = new System.Drawing.Point(491, 27);
            this.txtbProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbProductId.Name = "txtbProductId";
            this.txtbProductId.ReadOnly = true;
            this.txtbProductId.Size = new System.Drawing.Size(242, 28);
            this.txtbProductId.TabIndex = 0;
            this.txtbProductId.TabStop = false;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveProduct.AutoSize = true;
            this.btnSaveProduct.Location = new System.Drawing.Point(140, 3);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(131, 41);
            this.btnSaveProduct.TabIndex = 1;
            this.btnSaveProduct.Text = "Guardar";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1116, 695);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditProduct.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Location = new System.Drawing.Point(3, 3);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(131, 41);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Visible = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnEditProduct);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveProduct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 689);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 47);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1250, 739);
            this.Controls.Add(this.typMain);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.ShowIcon = false;
            this.Text = "frmProduct";
            this.typMain.ResumeLayout(false);
            this.typMain.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.flpSellPriceInputType.ResumeLayout(false);
            this.flpSellPriceInputType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductBuyPrice)).EndInit();
            this.flpStockInputType.ResumeLayout(false);
            this.flpStockInputType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductStock)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel typMain;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.TextBox txtbProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtbProductName;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label lblProductVariant;
        private System.Windows.Forms.TextBox txtbProductVariant;
        private System.Windows.Forms.RadioButton rbStockSub;
        private System.Windows.Forms.RadioButton rbStockAdd;
        private System.Windows.Forms.RadioButton rbStockSet;
        private System.Windows.Forms.NumericUpDown nudProductStock;
        private System.Windows.Forms.FlowLayoutPanel flpStockInputType;
        private System.Windows.Forms.NumericUpDown nudProductSellPrice;
        private System.Windows.Forms.Label lblProductSellPrice;
        private System.Windows.Forms.NumericUpDown nudProductBuyPrice;
        private System.Windows.Forms.Label lblProductBuyPrice;
        private System.Windows.Forms.FlowLayoutPanel flpSellPriceInputType;
        private System.Windows.Forms.RadioButton rbSellPriceManual;
        private System.Windows.Forms.RadioButton rbSellPricePorcent;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}