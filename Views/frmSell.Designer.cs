namespace ScannerReader.Views
{
    partial class FrmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSell));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductTable = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudTotalSell = new System.Windows.Forms.NumericUpDown();
            this.btnAddKilogramProduct = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSell)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            resources.ApplyResources(this.tlpMain, "tlpMain");
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.Controls.Add(this.gbQuantity, 1, 2);
            this.tlpMain.Controls.Add(this.btnReload, 2, 3);
            this.tlpMain.Controls.Add(this.btnClose, 3, 3);
            this.tlpMain.Controls.Add(this.btnSell, 0, 3);
            this.tlpMain.Controls.Add(this.lblTitle, 1, 0);
            this.tlpMain.Controls.Add(this.panel1, 1, 3);
            this.tlpMain.Controls.Add(this.dgvProductTable, 0, 1);
            this.tlpMain.Controls.Add(this.nudTotalSell, 0, 2);
            this.tlpMain.Controls.Add(this.btnAddKilogramProduct, 3, 0);
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Name = "tlpMain";
            // 
            // gbQuantity
            // 
            this.gbQuantity.Controls.Add(this.nudQuantity);
            this.gbQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbQuantity.ForeColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.gbQuantity, "gbQuantity");
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.TabStop = false;
            // 
            // nudQuantity
            // 
            resources.ApplyResources(this.nudQuantity, "nudQuantity");
            this.nudQuantity.InterceptArrowKeys = false;
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnSell, "btnSell");
            this.btnSell.Name = "btnSell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dgvProductTable
            // 
            this.dgvProductTable.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvProductTable, "dgvProductTable");
            this.dgvProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.name,
            this.variant,
            this.price});
            this.tlpMain.SetColumnSpan(this.dgvProductTable, 4);
            this.dgvProductTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductTable.MultiSelect = false;
            this.dgvProductTable.Name = "dgvProductTable";
            this.dgvProductTable.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvProductTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductTable.RowTemplate.Height = 24;
            this.dgvProductTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductTable.ShowEditingIcon = false;
            this.dgvProductTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductTable_CellValueChanged);
            this.dgvProductTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductTable_RowsAdded);
            this.dgvProductTable.SelectionChanged += new System.EventHandler(this.dgvProductTable_SelectionChanged);
            this.dgvProductTable.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvProductTable_PreviewKeyDown);
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // variant
            // 
            resources.ApplyResources(this.variant, "variant");
            this.variant.Name = "variant";
            this.variant.ReadOnly = true;
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // nudTotalSell
            // 
            resources.ApplyResources(this.nudTotalSell, "nudTotalSell");
            this.nudTotalSell.BackColor = System.Drawing.Color.Black;
            this.nudTotalSell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.nudTotalSell, 2);
            this.nudTotalSell.DecimalPlaces = 2;
            this.nudTotalSell.ForeColor = System.Drawing.Color.LimeGreen;
            this.nudTotalSell.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudTotalSell.Name = "nudTotalSell";
            this.nudTotalSell.ReadOnly = true;
            this.nudTotalSell.TabStop = false;
            this.nudTotalSell.Paint += new System.Windows.Forms.PaintEventHandler(this.nudTotalSell_Paint);
            // 
            // btnAddKilogramProduct
            // 
            this.btnAddKilogramProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnAddKilogramProduct, "btnAddKilogramProduct");
            this.btnAddKilogramProduct.Name = "btnAddKilogramProduct";
            this.btnAddKilogramProduct.UseVisualStyleBackColor = false;
            this.btnAddKilogramProduct.Click += new System.EventHandler(this.btnAddKilogramProduct_Click);
            // 
            // FrmSell
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSell";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSell_FormClosing);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dgvProductTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudTotalSell;
        private System.Windows.Forms.GroupBox gbQuantity;
        private System.Windows.Forms.Button btnAddKilogramProduct;
    }
}