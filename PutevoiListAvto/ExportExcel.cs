using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace PutevoiListAvto
{
    class ExportExcel
    {
        Excel.Application ex;
        Excel.Worksheet sheet;
        Excel.Worksheet workSheet2;
        public void CreateExcelPutevoi(string[,] data)
        {          
            ex = new Excel.Application();
            ex.Visible = false;
            ex.DisplayAlerts = true;
            string path = Directory.GetCurrentDirectory() + "\\PutevoiTemp.xlsx";
            ex.Workbooks.Open(path);
            sheet = (Excel.Worksheet)ex.Worksheets.get_Item(2);
            Excel.Range range1 = (Excel.Range)sheet.Cells[7, 1];
            Excel.Range rowRange = range1.EntireRow;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
            }

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            sheet.Cells[i + 6, j + 2] = data[i, j];
                            break;
                        case 1:
                            sheet.Cells[i + 6, j + 2] = data[i, j];
                            break;
                        case 2:
                            sheet.Cells[i + 6, j + 2] = data[i, j];
                            break;
                        case 3:
                            sheet.Cells[i + 6, j + 2] = data[i, j];
                            break;
                        case 4:
                            sheet.Cells[i + 6, j + 6] = data[i, j];
                            break;
                    }
                }
            }

            sheet.Cells[14 + data.GetLength(0), 4] = SummKM(data);
            workSheet2 = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            string[] currentDate = returnPutevoiDate(data[0, 1]);
            workSheet2.Cells[5, "AD"] = currentDate[0];
            workSheet2.Cells[5, "Ai"] = currentDate[1];
            workSheet2.Cells[5, "AU"] = currentDate[2];

            TableStyle(data);
            SaveExcel();
        }
        private string[] returnPutevoiDate(string baseDate)
        {
            string[] result = baseDate.Split('.');
            int mounth = int.Parse(result[1]);
            int year= int.Parse(result[2]);
            result[0] = DateTime.DaysInMonth(year, mounth).ToString();
            return result;
        }
        private void TableStyle(string[,] data)
        {
            Excel.Range C1 = sheet.Cells[6, 2];
            Excel.Range C4 = sheet.Cells[5 + data.GetLength(0), 6 + data.GetLength(1)];
            Excel.Range range1 = sheet.get_Range(C1, C4);
            Excel.Range A1 = workSheet2.Cells[5, "AD"];
            Excel.Range A2 = workSheet2.Cells[5, "AU"];
            Excel.Range fstListRange = workSheet2.get_Range(A1, A2);
            fstListRange.Cells.Font.Size = 10;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.EntireRow.AutoFit();
            //range1.EntireColumn.AutoFit(); 
            range1.WrapText = true;
        }
        private double SummKM(string[,] data)
        {
            double summ = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                summ += double.Parse(data[i, 4]);
            }
            return summ;
        }

        public void CreateExcelOtchet(List<string[]> data, string Rashod, string Cost)
        {
            ex = new Excel.Application();
            ex.DisplayAlerts = true;
            ex.Visible = false;
            string path = Directory.GetCurrentDirectory() + "\\Otchet.xlsx";
            ex.Workbooks.Open(path);
            sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            int i = 0;
            double fullKm = 0; double fullRashod = 0; double fullCost = 0;
            foreach (string[] dataArray in data)
            {
                for (int j = 0; j < dataArray.Length; j++)
                {
                    switch (j)
                    {
                        case 1:
                            sheet.Cells[i + 5, j + 1] = dataArray[j];
                            break;
                        case 2:
                            string buffer = "";
                            if (i != 0)
                                buffer = " " + dataArray[j];
                            else
                                buffer = dataArray[j];
                            sheet.Cells[i + 5, j + 5] = buffer;
                            break;
                        case 3:
                            {
                                sheet.Cells[i + 5, j] = dataArray[j];
                                fullKm += double.Parse(dataArray[j]);
                            }
                            break;
                    }
                }
                sheet.Cells[i + 5, 5] = double.Parse(Rashod) / 100;
                double summRashod = double.Parse(Rashod) / 100 * double.Parse(dataArray[3]);
                sheet.Cells[i + 5, 4] = summRashod;
                fullRashod += summRashod;
                sheet.Cells[i + 5, 6] = summRashod * double.Parse(Cost);
                fullCost += summRashod * double.Parse(Cost);
                i += 1;
            }
            sheet.Cells[5 + data.Count, 2] = "ИТОГ";
            sheet.Cells[5 + data.Count, 3] = fullKm;
            sheet.Cells[5 + data.Count, 4] = fullRashod;
            sheet.Cells[5 + data.Count, 6] = fullCost;
            sheet.Cells[2, 5] = MonthPeriod(data[0][1]);
            sheet.Cells[3, 9] = Cost;
            Table2Style(data);
            SaveExcel();

        }

        private string MonthPeriod(string period)
        {
            string[] buf = period.Split('.');
            int mounth = int.Parse(buf[1]);
            int year = int.Parse(buf[2]);
            buf[0] = DateTime.DaysInMonth(year, mounth).ToString();
            string result = "Расход топлива с 01." + buf[1] + "." + buf[2] + " по "+buf[0] +"."+buf[1] + "." + buf[2];
            return result;
        }
        private void Table2Style(List<string[]> data)
        {
            Excel.Range C1 = sheet.Cells[4, 2];
            Excel.Range C2 = sheet.Cells[2, 5];
            Excel.Range C3 = sheet.Cells[5 + data.Count, 2];
            Excel.Range C4 = sheet.Cells[5 + data.Count, 7];
            Excel.Range range1 = sheet.get_Range(C1, C4);
            C2.Font.Bold = true;
            C3.Font.Bold = true;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.get_Item(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.EntireRow.AutoFit();
            range1.WrapText = true;
            //range1.EntireColumn.AutoFit(); 
        }



        private void SaveExcel()
        {
            SaveFileDialog sDial = new SaveFileDialog();
            sDial.InitialDirectory = @"C:\\";
            sDial.Filter = "File(*xlsx)|*.xlsx";
            sDial.FilterIndex = 0;
            sDial.RestoreDirectory = true;
            sDial.Title = "Экспорт";
            if (sDial.ShowDialog() == DialogResult.Cancel)
            {
                ex.Application.ActiveWorkbook.Close();
                ex.Quit();
                return;
            }
            string path = sDial.FileName;
            ex.Application.ActiveWorkbook.SaveCopyAs(path);
            ex.Application.ActiveWorkbook.Saved = true;
            ex.Application.ActiveWorkbook.Close();
            ex.Quit();
            ex.Visible = true;
            ex.Workbooks.Open(path);
        }
    }
}
