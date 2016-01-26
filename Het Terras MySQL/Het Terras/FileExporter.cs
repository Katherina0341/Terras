using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Het_Terras
{
    public class FileExporter
    {     

        public bool ExportToExcel(List<WeeklyActivity> data, string start, string end)
        {

            var sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files(*.xlsx) | *.xlsx";
            sfd.FileName = string.Format("{0} - {1}.xlsx",start, end);         
           
            if (System.IO.File.Exists(sfd.FileName))
            {
                System.IO.File.Delete(sfd.FileName);
            }
           
            if (sfd.ShowDialog() != true)
            {
                return false;
            }


            var excelApp = new Excel.Application();
            excelApp.Visible = false;
            var wb = excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "First name";
            workSheet.Cells[1, "B"] = "Monday";
            workSheet.Cells[1, "C"] = "Tuesday";
            workSheet.Cells[1, "D"] = "Wednesday";
            workSheet.Cells[1, "E"] = "Thursday";
            workSheet.Cells[1, "F"] = "Friday";
            workSheet.Cells[1, "G"] = "Saturday";
            workSheet.Cells[1, "H"] = "Sunday";
            workSheet.Cells[1, "I"] = "TotalHours";
            workSheet.Cells[1, "J"] = "Breaks";
            workSheet.Cells[1, "K"] = "PaidHours";

            for (int i = 0; i < data.Count; i++)
            {
                var activity = data[i];
                workSheet.Cells[i + 2, "A"] = activity.User;
                workSheet.Cells[i + 2, "B"] = activity.MondayActivity;
                workSheet.Cells[i + 2, "C"] = activity.TuesdayActivity;
                workSheet.Cells[i + 2, "D"] = activity.WednesdayActivity;
                workSheet.Cells[i + 2, "E"] = activity.ThursdayActivity;
                workSheet.Cells[i + 2, "F"] = activity.FridayActivity;
                workSheet.Cells[i + 2, "G"] = activity.SaturdayActivity;
                workSheet.Cells[i + 2, "H"] = activity.SundayActivity;
                workSheet.Cells[i + 2, "I"] = activity.TotalHours;
                workSheet.Cells[i + 2, "J"] = activity.Breaks;
                workSheet.Cells[i + 2, "K"] = activity.PaidHours;

            }
            workSheet.Rows.RowHeight = 32;
            workSheet.Columns.ColumnWidth = 20;
            excelApp.ActiveWorkbook.SaveAs(sfd.FileName);
            excelApp.Quit();
            return true;
        }
    }
}
