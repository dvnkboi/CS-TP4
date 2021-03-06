using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace ModelApp
{
    public class ConvEngine
    {

        private static void CreateHeader<T>(List<T> list, StreamWriter sw)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            for (int i = 0; i < properties.Length - 1; i++)
            {
                sw.Write(properties[i].Name + ",");
            }
            var lastProp = properties[properties.Length - 1].Name;
            sw.Write(lastProp + sw.NewLine);
        }

        private static void CreateRows<T>(List<T> list, StreamWriter sw)
        {
            foreach (var item in list)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();
                for (int i = 0; i < properties.Length - 1; i++)
                {
                    var prop = properties[i];
                    sw.Write(prop.GetValue(item) + ",");
                }
                var lastProp = properties[properties.Length - 1];
                sw.Write(lastProp.GetValue(item) + sw.NewLine);
            }
        }

        public static void CreateCSV<T>(List<T> list, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                CreateHeader(list, sw);
                CreateRows(list, sw);
            }
        }

        public static void CreateXLS<T>(List<T> list, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var xls = new ExcelPackage(filePath))
            {
                var target = xls.Workbook.Worksheets.SingleOrDefault(x => x.Name == typeof(T).Name);
                if(target != null) 
                    xls.Workbook.Worksheets.Delete(target);
                var worksheet = xls.Workbook.Worksheets.Add(typeof(T).Name);
                worksheet.Cells["A1"].LoadFromCollection(Collection: list, PrintHeaders: true);
                xls.Save();
            }
        }
    }
}
