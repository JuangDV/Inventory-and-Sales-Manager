using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.OneD.RSS;

namespace ScannerReader.Model
{
    public class Product
    {
        private string id;
        private string name;
        private string variant;
        private double stock;
        private double buyPrice;
        private double sellPrice;
        private SellPriceCalcStyle sellPriceInputType;
        private StockInputStyle stockInputType;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Variant { get => variant; set => variant = value; }
        public double Stock { get => stock; set => stock = value; }
        public double BuyPrice { get => buyPrice; set => buyPrice = value; }
        public double SellPrice { get => sellPrice; set => sellPrice = value; }
        public SellPriceCalcStyle SellPriceInputType { get => sellPriceInputType; set => sellPriceInputType = value; }
        public StockInputStyle StockInputType { get => stockInputType; set => stockInputType = value; }

        public Product(string id, string name, string variant = null, double stock = 0, double buyPrice = 0, double sellPrice = 0,
            StockInputStyle stockInputType = default, SellPriceCalcStyle sellPriceInputType = default)
        {
            Id = id;
            Name = name;
            Variant = variant;
            Stock = stock;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            SellPriceInputType = sellPriceInputType;
            StockInputType = stockInputType;
        }

        public Product()
        {
        }

        public bool Add()
        {
            bool productAdded = false;

            if(Find(Id).id == null)
            {
                var excelFile = new ClosedXML.Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
                var excelSheet = excelFile.Worksheets.Worksheet("Productos");

                var row = excelSheet.Column("A").LastCellUsed().CellBelow().ToString().Substring(1);

                excelSheet.Cell("A" + row).Value = Id;
                excelSheet.Cell("B" + row).Value = Name;
                excelSheet.Cell("C" + row).Value = Variant;
                excelSheet.Cell("D" + row).Value = Stock;
                excelSheet.Cell("E" + row).Value = BuyPrice;
                if (SellPriceInputType == SellPriceCalcStyle.Manual)
                {
                    excelSheet.Cell("F" + row).Value = SellPrice;
                }
                else
                {
                    excelSheet.Cell("F" + row).FormulaA1 = $"=E{row}+(E{row}/100*{SellPrice})";
                }

                excelFile.Save();
                productAdded = true;
            }

            return productAdded;
        }

        public bool Update(Product product)
        {
            bool updateStatus = false;

            if ((product.id != null) && (product.Find(product.id).id != null))
            {
                var excelFile = new ClosedXML.Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
                var excelSheet = excelFile.Worksheets.Worksheet("Productos");

                var row = excelSheet.Column("A").CellsUsed().FirstOrDefault(e => e.Value.ToString().Equals(product.id)).Address.ToString().Substring(1);

                excelSheet.Cell("A" + row).Value = Id;
                excelSheet.Cell("B" + row).Value = Name;
                excelSheet.Cell("C" + row).Value = Variant;
                excelSheet.Cell("D" + row).Value = Stock;
                excelSheet.Cell("E" + row).Value = BuyPrice;
                if (SellPriceInputType == SellPriceCalcStyle.Manual)
                {
                    excelSheet.Cell("F" + row).Value = SellPrice;
                }
                else
                {
                    excelSheet.Cell("F" + row).FormulaA1 = $"=E{row}+(E{row}/100*{SellPrice})";
                }

                excelFile.Save();
                updateStatus = true;
            }

            return updateStatus;
        }

        public Product Find(string id)
        {
            Product product = new Product();
            decimal money;

            IEnumerable<ClosedXML.Excel.IXLCell> productCell = null;
            var excelFile = new ClosedXML.Excel.XLWorkbook(".\\BASEDEDATOS.xlsx");
            var excelSheet = excelFile.Worksheets.Worksheet("Productos");
            var cell = excelSheet.Column("A").CellsUsed().FirstOrDefault(cellSelected => cellSelected.Value.ToString() == id);
            if (cell != null)
            {
                string row = cell.ToString().Substring(1);
                productCell = excelSheet.Cells($"A{row}:F{row}");
                product.Id = productCell.ElementAt(0).Value.ToString();
                product.Name = productCell.ElementAt(1).Value.ToString();
                product.Variant = productCell.ElementAt(2).Value.ToString();
                product.Stock = (int)productCell.ElementAt(3).Value;
                product.BuyPrice = double.Parse(productCell.ElementAt(4).Value.ToString());
                if (productCell.ElementAt(5).HasFormula == false)
                {
                    decimal.TryParse(productCell.ElementAt(5).Value.ToString(), out money);
                }
                else if (!productCell.ElementAt(5).IsEmpty())
                {
                    string formulaPorcent = productCell.ElementAt(5).FormulaA1.ToString().Split('*').ElementAt(1).Replace(")", "");
                    if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString() == ",")
                    {
                        formulaPorcent = formulaPorcent.Replace(".", ",");
                    }
                    decimal.TryParse(formulaPorcent, out money);
                    product.SellPriceInputType = SellPriceCalcStyle.Porcent;
                }
                else
                {
                    money = 0;
                }
                product.SellPrice = (double)money;
            }

            excelFile.Save();

            return product;
        }
    }
}
