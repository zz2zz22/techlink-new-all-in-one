using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techlink_new_all_in_one.MainController.SubLogic.FontEmbedded
{
    public class CustomFont
    {
        public static PrivateFontCollection pfc;

        private static string GetFontPath (string fileName)
        {
            string FileName = Environment.CurrentDirectory + @"\Resources\" + fileName;
            return FileName;
        }

        public static void LoadCustomFont()
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile(GetFontPath("BalooChettan2-VariableFont_wght.ttf"));//start at 0
        }
    }
}
