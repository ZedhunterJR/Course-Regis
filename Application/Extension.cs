using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public static class Extension
    {
        public static Color DColor(this string dId, int term)
        {
            if (term == 0)
            //change these colors
            switch (dId)
            {
                case "000001d":
                    return ColorTranslator.FromHtml("#ffb366");
                case "000123a":
                    return ColorTranslator.FromHtml("#0099e6");
                case "230012b":
                    return ColorTranslator.FromHtml("#e60073");
                case "382322c":
                    return ColorTranslator.FromHtml("#7300e6");
            }   
            if (term == -1)
                return Color.DarkRed;
            return Color.Gray;
        }

        //probaly will cause exception, but oh well
        public static DataRow UncheckedFindId(this DataTable dt,  string id)
        {
            DataRow[] row = dt.Select("id = " + "'" + id + "'");
            if (row != null)
            {
                return row[0];
            }
            return null;
        }
        public static void SetDoubleBuffered(this System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        public static System.Drawing.Bitmap ImageConverter(this byte[] arg)
        {
            System.Drawing.Bitmap bitmap = null;
            ImageConverter converter = new ImageConverter();
            System.Drawing.Image img =
            (System.Drawing.Image)converter.ConvertFrom(arg);
            bitmap = (System.Drawing.Bitmap)img;
            return bitmap;
        }
        public static byte[] ImageReverter(this Image img)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            //return arr.ByteArrayToString();
            return arr;
        }

        public static string UserRole(this string role)
        {
            switch (role)
            {
                case "student": return "Student"; 
                case "lecturer": return "Faculty Member"; 
                case "faculty": return "Faculty Member"; 
                case "admin": return "Admin"; 
            }
            return "Unknown";
        }
        public static Color UColor(this string role)
        {
            switch (role)
            {
                case "student": return ColorTranslator.FromHtml("#8080ff");
                case "faculty": return ColorTranslator.FromHtml("#33cc33");
                case "lecturer": return ColorTranslator.FromHtml("#33cc33");
                case "admin": return ColorTranslator.FromHtml("#bf80ff");
            }
            return Color.Black;
        }

        public static DateTime CheckDateFormat(this string s)
        {
            DateTime.TryParseExact(s, "yyyy-mm-dd", null, DateTimeStyles.None, out DateTime dt);
            return dt;
        }

        public static int CompareCourseTerm(this int a)
        {
            if (a < DBOAccess.Instance.CurrentTerm())
                return -1;
            if (a == DBOAccess.Instance.CurrentTerm())
                return 0;
            return 1;
        }
    }
}
