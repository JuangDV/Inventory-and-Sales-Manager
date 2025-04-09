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
            this.tsddbSales = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiVender = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLector = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbLector = new System.Windows.Forms.ToolStripComboBox();
            this.txtbBarcodeReader = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.typScanInfo = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.typScanInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            resources.ApplyResources(this.pictureBoxCamera, "pictureBoxCamera");
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.TabStop = false;
            // 
            // textBoxBarcode
            // 
            resources.ApplyResources(this.textBoxBarcode, "textBoxBarcode");
            this.textBoxBarcode.BackColor = System.Drawing.Color.Black;
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarcode.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.ReadOnly = true;
            this.textBoxBarcode.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbInventory,
            this.tsddbSales,
            this.tsddbSettings});
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.Name = "mnuMain";
            // 
            // tsddbInventory
            // 
            this.tsddbInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRead});
            resources.ApplyResources(this.tsddbInventory, "tsddbInventory");
            this.tsddbInventory.Name = "tsddbInventory";
            this.tsddbInventory.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbInventory_DropDownItemClicked);
            // 
            // tsmiRead
            // 
            this.tsmiRead.Checked = true;
            this.tsmiRead.CheckOnClick = true;
            this.tsmiRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiRead.Name = "tsmiRead";
            resources.ApplyResources(this.tsmiRead, "tsmiRead");
            this.tsmiRead.Click += new System.EventHandler(this.leerToolStripMenuItem_Click);
            // 
            // tsddbSales
            // 
            this.tsddbSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVender});
            resources.ApplyResources(this.tsddbSales, "tsddbSales");
            this.tsddbSales.Name = "tsddbSales";
            // 
            // tsmiVender
            // 
            this.tsmiVender.Name = "tsmiVender";
            resources.ApplyResources(this.tsmiVender, "tsmiVender");
            this.tsmiVender.Click += new System.EventHandler(this.tsmiVender_Click);
            // 
            // tsddbSettings
            // 
            this.tsddbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLector});
            resources.ApplyResources(this.tsddbSettings, "tsddbSettings");
            this.tsddbSettings.Name = "tsddbSettings";
            // 
            // tsmiLector
            // 
            this.tsmiLector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbLector});
            this.tsmiLector.Name = "tsmiLector";
            resources.ApplyResources(this.tsmiLector, "tsmiLector");
            // 
            // tscbLector
            // 
            this.tscbLector.Name = "tscbLector";
            resources.ApplyResources(this.tscbLector, "tscbLector");
            this.tscbLector.SelectedIndexChanged += new System.EventHandler(this.tscbLector_SelectedIndexChanged);
            // 
            // txtbBarcodeReader
            // 
            resources.ApplyResources(this.txtbBarcodeReader, "txtbBarcodeReader");
            this.txtbBarcodeReader.Name = "txtbBarcodeReader";
            this.txtbBarcodeReader.Enter += new System.EventHandler(this.txtbBarcodeReader_Enter);
            this.txtbBarcodeReader.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbBarcodeReader_KeyPress);
            this.txtbBarcodeReader.Leave += new System.EventHandler(this.txtbBarcodeReader_Leave);
            // 
            // typScanInfo
            // 
            resources.ApplyResources(this.typScanInfo, "typScanInfo");
            this.typScanInfo.BackColor = System.Drawing.Color.Black;
            this.typScanInfo.Controls.Add(this.txtbBarcodeReader, 0, 2);
            this.typScanInfo.Controls.Add(this.pictureBoxCamera, 0, 0);
            this.typScanInfo.Controls.Add(this.textBoxBarcode, 0, 1);
            this.typScanInfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.typScanInfo.Name = "typScanInfo";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.typScanInfo);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
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

