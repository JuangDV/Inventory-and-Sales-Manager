using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using ZXing.Common;
using System.Drawing.Imaging;
using System.Threading;
using Excel = ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2019.Excel.RichData;
using System.Runtime.Remoting.Channels;

namespace ScannerReader.Views
{
    public partial class frmMain : Form
    {

        private FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        private VideoCaptureDevice videoSource;
        private int deviceSelected = 0;
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
            for (int i = 0; i<videoDevices.Count; i++)
            {
                tscbLector.Items.Add(videoDevices[i].Name);
            }
            tscbLector.ComboBox.SelectedIndex = deviceSelected+1;
        }
        private void cameraChange(int index)
        {
            if((videoSource == null) || (!videoSource.IsRunning))
            {
                deviceSelected = index;
                onCamera();
            } else
            {
                videoSource.SignalToStop();
                videoSource = null;
                deviceSelected = index;
                onCamera();
            }
        }


        private void onCamera()
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
            } else if (deviceSelected == -1)
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
                        pictureBoxCamera.Invoke(new MethodInvoker (delegate
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
                                execute(result.Text);
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

        private async void execute(string result)
        {
            getCode = false;
            Console.Beep();

            switch (modeCode)
            {
                case ('A'):
                    {
                        var cell = searchProduct(result);
                        if (cell == null)
                        {
                            Form frmAgregar = new frmAgregar(result);
                            OpenChildForm(frmAgregar);
                        }
                        else
                        {
                            MessageBox.Show($"El producto '{cell.ToArray()[1].Value}' ya existe", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }

                        break;
                    }
                case ('E'):
                    {
                        var cell = searchProduct(result);
                        if (cell != null)
                        {
                            Form frmEdit = new frmEdit(cell);
                            OpenChildForm(frmEdit);
                        }
                        else
                        {
                            MessageBox.Show($"El producto no existe", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        break;
                    }
                default:
                    {
                        var cell = searchProduct(result);
                        if (cell != null)
                        {
                            readProduct(result);
                        }
                        else
                        {
                            MessageBox.Show($"El producto no existe", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            modeCode = 'r';
            onCamera();
        }

        private void readProduct(string result)
        {
            var product = searchProduct(result).ToArray();

            textBoxBarcode.Invoke(new MethodInvoker(delegate
            {
                if (product != null)
                {
                    string productName = product[1].Value.ToString();
                    string productVariant = product[2].Value.ToString();
                    string productStock = product[3].Value.ToString();
                    string productBuyPrice = product[4].Value.ToString();
                    string productSellPrice = product[5].Value.ToString();

                    textBoxBarcode.Text = $"Producto: {productName}\r\nVariante: {productVariant}" +
                    $"\r\nStock: {productStock} " + (int.Parse(productStock)==1 ? "Unidad":"Unidades") +
                    $"\r\nPrecio de Compra: ${productBuyPrice} \r\nPrecio de Venta: ${productSellPrice}";
                }
                else
                {
                    MessageBox.Show("Producto no registrado", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }));
        }

        private IEnumerable<Excel.IXLCell> searchProduct(string code)
        {
            IEnumerable<Excel.IXLCell> product = null;
            var excelFile = new Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
            var excelSheet = excelFile.Worksheets.Worksheet("Productos");
            var cell = excelSheet.CellsUsed().FirstOrDefault(cellSelected => cellSelected.Value.ToString() == code);
            if (cell != null)
            {
                string row = cell.ToString().Substring(1);
                product = excelSheet.Cells($"A{row}:F{row}");
            }
            
            excelFile.Save();

            return product;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeCode = 'E';
            onCamera();
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
                childForm.Show();

                childForm.Dock = DockStyle.Fill;

                childForm.BringToFront();
            }
        }
        

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeCode = 'r';
            onCamera();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeCode = 'E';
            onCamera();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modeCode = 'A';
            onCamera();
        }

        private void tscbLector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ToolStripComboBox)sender).SelectedIndex;
            cameraChange(index - 1);
        }

        private void txtbBarcodeReader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)) || (char.IsControl(e.KeyChar)))
            {
                if ((e.KeyChar == (char)Keys.Enter) && (txtbBarcodeReader.Text.Length > 0))
                {
                    execute(txtbBarcodeReader.Text);
                    txtbBarcodeReader.Text = null;
                }
            } else
            {
                e.Handled = true;
            }
        }

        private void tsddbInventory_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach(ToolStripMenuItem item in tsddbInventory.DropDownItems)
            {
                if (!item.Equals(e.ClickedItem)) item.Checked = false;
            }
        }

        private void tsmiVender_Click(object sender, EventArgs e)
        {

        }
    }
}


