using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyThuVien
{
    public class ExcelExport
    {

        public void export2ExcelSpecial(DataGridView g, string duongDan, string tenTap)
        {
            string fontName = "Times New Roman";
            int fontSizeTenTruong = 14;
            int fontSizeNoiDung = 12;
            Microsoft.Office.Interop.Excel.Application app = new Excel.Application(); //Tạo application mới

            app.Application.Workbooks.Add(Type.Missing);
            //Tạo mới một Excel WorkBook 

            //app.Visible = true;

            //app.DisplayAlerts = false;

            Excel.Workbook wb = (Excel.Workbook)(app.Workbooks.Add(Type.Missing));

            Excel.Sheets oSheets = wb.Worksheets;

            Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            Worksheet ws = (Worksheet)wb.Worksheets[1];

            //xuất tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = "Danh Sách";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int col = 1;
            for (int i = 1; i < g.Columns.Count; i++)
            {
                col++;
                //header
                app.Cells[2, i] = g.Columns[i - 1].HeaderText;
                app.Cells[2, i].Font.Size = fontSizeTenTruong;
                app.Cells[2, i].Font.Name = fontName;
                app.Cells[2, i].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                app.Cells[2, i].ColumnWidth = 20;
                //nền vàng
                app.Cells[2, i].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                app.Cells[2, i].Font.Bold = true;
                //chữ đen
                app.Cells[2, i].Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            int row = 1;
            for (int i = 0; i < g.Rows.Count; i++)
            {
                row++;
                for (int j = 0; j < g.Columns.Count - 1; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        app.Cells[i + 3, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                        app.Cells[i + 3, j + 1].Font.Size = fontSizeNoiDung;
                        app.Cells[i + 3, j + 1].Font.Name = fontName;
                        app.Cells[i + 3, j + 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    }
                }
            }

            //kẻ ô
            BorderAround(ws.get_Range("A2", "I" + row));
            string linksave = duongDan + tenTap + ".xlsx";
            app.ActiveWorkbook.SaveAs(linksave);
            app.ActiveWorkbook.Saved = true;
            app.Quit();
            releaseappect(ws);
            releaseappect(wb);
            releaseappect(app);

            System.Diagnostics.Process.Start(linksave);
        }
        public void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            string fontName = "Times New Roman";
            int fontSizeTenTruong = 14;
            int fontSizeNoiDung = 12;
            Microsoft.Office.Interop.Excel.Application app = new Excel.Application(); //Tạo application mới

            app.Application.Workbooks.Add(Type.Missing);
            //Tạo mới một Excel WorkBook 

            //app.Visible = true;

            //app.DisplayAlerts = false;

            Excel.Workbook wb = (Excel.Workbook)(app.Workbooks.Add(Type.Missing));

            Excel.Sheets oSheets = wb.Worksheets;

            Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            Worksheet ws = (Worksheet)wb.Worksheets[1];

            //xuất tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");
            head.MergeCells = true;
            head.Value2 = "Danh Sách";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int col = 1;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                col++;
                //header
                app.Cells[2, i] = g.Columns[i - 1].HeaderText;
                app.Cells[2, i].Font.Size = fontSizeTenTruong;
                app.Cells[2, i].Font.Name = fontName;
                app.Cells[2, i].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                app.Cells[2, i].ColumnWidth = 20;
                //nền vàng
                app.Cells[2, i].Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                app.Cells[2, i].Font.Bold = true;
                //chữ đen
                app.Cells[2, i].Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            }
            int row = 1;
            for (int i = 0; i < g.Rows.Count; i++)
            {
                row++;
                for (int j = 0; j < g.Columns.Count ; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        app.Cells[i + 3, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                        app.Cells[i + 3, j + 1].Font.Size = fontSizeNoiDung;
                        app.Cells[i + 3, j + 1].Font.Name = fontName;
                        app.Cells[i + 3, j + 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    }
                }
            }

            //kẻ ô
            BorderAround(ws.get_Range("A2", "I" + row));
            string linksave = duongDan + tenTap + ".xlsx";
            app.ActiveWorkbook.SaveAs(linksave);
            app.ActiveWorkbook.Saved = true;
            app.Quit();
            releaseappect(ws);
            releaseappect(wb);
            releaseappect(app);

            System.Diagnostics.Process.Start(linksave);
        }
        //Hàm thu hồi bộ nhớ cho Excel
        private static void releaseappect(object app)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                app = null;
            }
            finally
            { GC.Collect(); }
        }

        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
    }
}
