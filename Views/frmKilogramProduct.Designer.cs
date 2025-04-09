namespace ScannerReader.Views
{
    partial class frmKilogramProduct
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtbProductName = new System.Windows.Forms.TextBox();
            this.lblGrams = new System.Windows.Forms.Label();
            this.nudProductGrams = new System.Windows.Forms.NumericUpDown();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(88, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(73, 21);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Nombre";
            // 
            // txtbProductName
            // 
            this.txtbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbProductName.Location = new System.Drawing.Point(168, 6);
            this.txtbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbProductName.Name = "txtbProductName";
            this.txtbProductName.Size = new System.Drawing.Size(206, 28);
            this.txtbProductName.TabIndex = 2;
            // 
            // lblGrams
            // 
            this.lblGrams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(88, 43);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(73, 21);
            this.lblGrams.TabIndex = 3;
            this.lblGrams.Text = "Gramos";
            // 
            // nudProductGrams
            // 
            this.nudProductGrams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudProductGrams.Location = new System.Drawing.Point(168, 41);
            this.nudProductGrams.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudProductGrams.Name = "nudProductGrams";
            this.nudProductGrams.Size = new System.Drawing.Size(206, 28);
            this.nudProductGrams.TabIndex = 5;
            // 
            // nudProductPrice
            // 
            this.nudProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudProductPrice.DecimalPlaces = 2;
            this.nudProductPrice.Location = new System.Drawing.Point(168, 75);
            this.nudProductPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.Size = new System.Drawing.Size(206, 28);
            this.nudProductPrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(1, 224);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(114, 40);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmKilogramProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 265);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.nudProductPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudProductGrams);
            this.Controls.Add(this.lblGrams);
            this.Controls.Add(this.txtbProductName);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKilogramProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Producto por Peso";
            ((System.ComponentModel.ISupportInitialize)(this.nudProductGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtbProductName;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.NumericUpDown nudProductGrams;
        private System.Windows.Forms.NumericUpDown nudProductPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}