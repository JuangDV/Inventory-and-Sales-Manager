using AForge.Video;
using AForge.Video.DirectShow;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using ScannerReader.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Excel = ClosedXML.Excel;

namespace ScannerReader.Views
{
    public partial class frmMain : Form
    {

        private FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource;
        private int deviceSelected = -1;
        private bool getCode = true;
        private char modeCode = 'r';
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* SETTINGS SELECT SCANNER LIST */
            tscbLector.Items.Add("Escanér");
            for (int i = 0; i < videoDevices.Count; i++)
            {
                tscbLector.Items.Add(videoDevices[i].Name);
            }
            tscbLector.ComboBox.SelectedIndex = deviceSelected + 1;
        }
        private void CameraChange(int index)
        {
            if ((videoSource == null) || (!videoSource.IsRunning))
            {
                deviceSelected = index;
                OnCamera();
            }
            else
            {
                videoSource.SignalToStop();
                videoSource = null;
                deviceSelected = index;
                OnCamera();
            }
        }


        private void OnCamera()
        {
            if (((videoSource == null) || (!videoSource.IsRunning)) && (deviceSelected >= 0))
            {
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No camera found!");
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[deviceSelected].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                try
                {
                    videoSource.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error starting camera: " + ex.Message);
                }
            }
            else if (deviceSelected == -1)
            {
                txtbBarcodeReader.Select();
            }
        }




        /*

                VIDEO SOURCE NEW FRAME: MAPPING CAMERA FRAMES TO SCAN BARCODE

        */
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    if (pictureBoxCamera.InvokeRequired)
                    {
                        pictureBoxCamera.Invoke(new MethodInvoker(delegate
                        {
                            pictureBoxCamera.Image?.Dispose();
                            pictureBoxCamera.Image = new Bitmap(bitmap);
                        }));
                    }

                    // Debugging: Check if the camera captures an image
                    //Console.WriteLine("Frame captured successfully.");

                    ScanBarcode(bitmap);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing frame: " + ex.Message);
            }
        }

        /*

                SCAN BARCODE FUNCTION: READ AND SEND BARCODE

         */
        private async void ScanBarcode(Bitmap bitmap)
        {
            if (getCode == true)
            {
                Result result;
                try
                {
                    if (bitmap != null)
                    {
                        BarcodeReader reader = new BarcodeReader
                        {
                            AutoRotate = true,
                            Options = new ZXing.Common.DecodingOptions
                            {
                                TryHarder = true,
                                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.EAN_13, ZXing.BarcodeFormat.MAXICODE,
                                ZXing.BarcodeFormat.EAN_8, ZXing.BarcodeFormat.RSS_14}
                            }
                        };
                        if (reader != null)
                        {
                            result = reader.Decode(bitmap);
                            if (result == null)
                            {
                                //Console.WriteLine("No barcode detected.");
                                result = null;
                            }
                            else
                            {
                                Console.WriteLine("Barcode detected: " + result);
                                Execute(result.Text);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: BarcodeReader is null.");
                            result = null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Bitmap is null");
                        result = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error scanning barcode: " + ex.Message);
                    await Task.Delay(1000).ConfigureAwait(false);
                    getCode = true;
                }
            }
        }

        private async void Execute(string result)
        {
            getCode = false;
            Console.Beep();

            switch (modeCode)
            {
                default:
                    {
                        Product product = new Product();
                        product = product.Find(result);
                        if (product.Id != null)
                        {
                            if (this.MdiChildren.Length == 0)
                            {
                                Form frmRead = new frmProduct(result);
                                OpenChildForm(frmRead);
                            }
                            else
                            {
                                ReadProduct(result, (TextBox)this.ActiveMdiChild.Controls.Find("txtbProductList", true).FirstOrDefault());
                            }
                        }
                        else
                        {
                            DialogResult msgResult = MessageBox.Show($"El codigo {result} no fue encontrado \n¿Desea agregar el producto al inventario?", "Producto no registrado", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (msgResult == DialogResult.Yes)
                            {
                                Form frmProduct = new frmProduct(result);
                                OpenChildForm(frmProduct);
                            }
                        }
                        break;
                    }
            }
            await Task.Delay(1000).ConfigureAwait(false);
            getCode = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }
        private void ReadProduct(string result, TextBox outputBarcode = null)
        {
            if (outputBarcode == null) outputBarcode = textBoxBarcode;

            Product product = new Product();
            product = product.Find(result);

            outputBarcode.Invoke(new MethodInvoker(delegate
            {
                if (product.Id != null)
                {

                    if (this.ActiveMdiChild is FrmSell child)
                    {
                        int quantity = ((int.TryParse(this.ActiveMdiChild.Controls.Find("nudQuantity", true)[0].Text, out quantity)) && (quantity > 0)) ? quantity : (int)1;
                        child.AddProduct(product, quantity);
                    }
                    else
                    {
                        Form frmRead = new frmProduct(result);
                        OpenChildForm(frmRead);
                    }
                }
                else
                {
                    DialogResult msgResult = MessageBox.Show($"El codigo {result} no fue encontrado \n¿Desea agregar el producto al inventario?", "Producto no registrado", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (msgResult == DialogResult.Yes)
                    {
                        Form frmProduct = new frmProduct(result);
                        OpenChildForm(frmProduct);
                    }
                }
            }));
        }

        private void OpenChildForm(Form childForm)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Form>(OpenChildForm), childForm);
            }
            else
            {
                // Cierra la ventana activa si existe
                this.ActiveMdiChild?.Close();
                // Configura la nueva ventana como hijo del MDIContainer
                childForm.MdiParent = this;
                childForm.Activate();

                childForm.Dock = DockStyle.Fill;

                childForm.Show();
                childForm.BringToFront();
            }
        }


        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeCode = 'r';
            OnCamera();
        }

        private void tscbLector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ToolStripComboBox)sender).SelectedIndex;
            CameraChange(index - 1);
        }

        private void txtbBarcodeReader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                if ((e.KeyChar == (char)Keys.Enter) && (txtbBarcodeReader.Text.Length > 0))
                {
                    Execute(txtbBarcodeReader.Text);
                    txtbBarcodeReader.Text = null;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tsddbInventory_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in tsddbInventory.DropDownItems)
            {
                if (!item.Equals(e.ClickedItem)) item.Checked = false;
            }
        }

        private void tsmiVender_Click(object sender, EventArgs e)
        {
            Form frmSell = new FrmSell(pictureBoxCamera, typScanInfo);
            typScanInfo.Controls[2].Visible = false;
            OpenChildForm(frmSell);
        }
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                switch (this.ActiveMdiChild.Name)
                {
                    default:
                        tsmiRead.PerformClick();
                        tsddbInventory.Enabled = false;
                        break;
                }
            }
            else tsddbInventory.Enabled = true;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((char)e.KeyValue == (char)Keys.F1) txtbBarcodeReader.Select();
        }

        private void txtbBarcodeReader_Enter(object sender, EventArgs e)
        {
            var obj = (TextBox)sender;
            obj.BackColor = Color.Cyan;
            obj.ForeColor = Color.Black;
        }

        private void txtbBarcodeReader_Leave(object sender, EventArgs e)
        {
            var obj = (TextBox)sender;
            obj.BackColor = Color.White;
            obj.ForeColor = Color.Black;
        }
    }
}


