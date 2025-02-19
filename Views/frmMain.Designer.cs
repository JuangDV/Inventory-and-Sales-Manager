namespace ScannerReader.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.ToolStrip();
            this.tsddbInventory = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiRead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLector = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbLector = new System.Windows.Forms.ToolStripComboBox();
            this.txtbBarcodeReader = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.typScanInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tsddbSales = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiVender = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.typScanInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBoxCamera.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxCamera.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBoxCamera.MaximumSize = new System.Drawing.Size(500, 273);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(312, 185);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCamera.TabIndex = 1;
            this.pictureBoxCamera.TabStop = false;
            this.pictureBoxCamera.WaitOnLoad = true;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxBarcode.BackColor = System.Drawing.Color.Black;
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarcode.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxBarcode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxBarcode.Location = new System.Drawing.Point(3, 197);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBoxBarcode.Multiline = true;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.ReadOnly = true;
            this.textBoxBarcode.Size = new System.Drawing.Size(312, 562);
            this.textBoxBarcode.TabIndex = 11;
            this.textBoxBarcode.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbInventory,
            this.tsddbSales,
            this.tsddbSettings});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1482, 32);
            this.mnuMain.TabIndex = 13;
            // 
            // tsddbInventory
            // 
            this.tsddbInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRead,
            this.tsmiEdit,
            this.tsmiAdd});
            this.tsddbInventory.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsddbInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsddbInventory.Image")));
            this.tsddbInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbInventory.Name = "tsddbInventory";
            this.tsddbInventory.Size = new System.Drawing.Size(105, 29);
            this.tsddbInventory.Text = "Inventario";
            this.tsddbInventory.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbInventory_DropDownItemClicked);
            // 
            // tsmiRead
            // 
            this.tsmiRead.Checked = true;
            this.tsmiRead.CheckOnClick = true;
            this.tsmiRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiRead.Name = "tsmiRead";
            this.tsmiRead.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmiRead.Size = new System.Drawing.Size(225, 30);
            this.tsmiRead.Text = "Leer";
            this.tsmiRead.Click += new System.EventHandler(this.leerToolStripMenuItem_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.CheckOnClick = true;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiEdit.Size = new System.Drawing.Size(225, 30);
            this.tsmiEdit.Text = "Editar";
            this.tsmiEdit.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.CheckOnClick = true;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiAdd.Size = new System.Drawing.Size(225, 30);
            this.tsmiAdd.Text = "Agregar";
            this.tsmiAdd.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // tsddbSettings
            // 
            this.tsddbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLector});
            this.tsddbSettings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsddbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsddbSettings.Image")));
            this.tsddbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSettings.Name = "tsddbSettings";
            this.tsddbSettings.Size = new System.Drawing.Size(137, 29);
            this.tsddbSettings.Text = "Configuración";
            // 
            // tsmiLector
            // 
            this.tsmiLector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbLector});
            this.tsmiLector.Name = "tsmiLector";
            this.tsmiLector.Size = new System.Drawing.Size(224, 30);
            this.tsmiLector.Text = "Lector";
            // 
            // tscbLector
            // 
            this.tscbLector.Name = "tscbLector";
            this.tscbLector.Size = new System.Drawing.Size(121, 28);
            this.tscbLector.Text = "Predeterminado";
            this.tscbLector.SelectedIndexChanged += new System.EventHandler(this.tscbLector_SelectedIndexChanged);
            // 
            // txtbBarcodeReader
            // 
            this.txtbBarcodeReader.Location = new System.Drawing.Point(2, 767);
            this.txtbBarcodeReader.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbBarcodeReader.Name = "txtbBarcodeReader";
            this.txtbBarcodeReader.Size = new System.Drawing.Size(314, 27);
            this.txtbBarcodeReader.TabIndex = 1;
            this.txtbBarcodeReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbBarcodeReader_KeyPress);
            // 
            // typScanInfo
            // 
            this.typScanInfo.AutoSize = true;
            this.typScanInfo.BackColor = System.Drawing.Color.Transparent;
            this.typScanInfo.ColumnCount = 1;
            this.typScanInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.typScanInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typScanInfo.Controls.Add(this.txtbBarcodeReader, 0, 2);
            this.typScanInfo.Controls.Add(this.pictureBoxCamera, 0, 0);
            this.typScanInfo.Controls.Add(this.textBoxBarcode, 0, 1);
            this.typScanInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.typScanInfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.typScanInfo.Location = new System.Drawing.Point(1164, 32);
            this.typScanInfo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.typScanInfo.Name = "typScanInfo";
            this.typScanInfo.RowCount = 3;
            this.typScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.3125F));
            this.typScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.6875F));
            this.typScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.typScanInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.typScanInfo.Size = new System.Drawing.Size(318, 796);
            this.typScanInfo.TabIndex = 15;
            // 
            // tsddbSales
            // 
            this.tsddbSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVender});
            this.tsddbSales.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.tsddbSales.Image = ((System.Drawing.Image)(resources.GetObject("tsddbSales.Image")));
            this.tsddbSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSales.Name = "tsddbSales";
            this.tsddbSales.Size = new System.Drawing.Size(78, 29);
            this.tsddbSales.Text = "Ventas";
            this.tsddbSales.ToolTipText = "Ventas";
            // 
            // tsmiVender
            // 
            this.tsmiVender.Name = "tsmiVender";
            this.tsmiVender.Size = new System.Drawing.Size(224, 30);
            this.tsmiVender.Text = "Vender";
            this.tsmiVender.Click += new System.EventHandler(this.tsmiVender_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1482, 828);
            this.Controls.Add(this.typScanInfo);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Inventario";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.typScanInfo.ResumeLayout(false);
            this.typScanInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.ToolStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiLector;
        private System.Windows.Forms.ToolStripComboBox tscbLector;
        private System.Windows.Forms.TextBox txtbBarcodeReader;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TableLayoutPanel typScanInfo;
        private System.Windows.Forms.ToolStripDropDownButton tsddbInventory;
        private System.Windows.Forms.ToolStripMenuItem tsmiRead;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiVender;
    }
}

