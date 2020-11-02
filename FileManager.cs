using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace remote_csgo
{
    public static class FileManager
    {


        public static string CSGODirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg";
        public static string GetFilePath(string Initdir, string Filter, string Title )
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.InitialDirectory = Initdir;
            OpenDialog.Filter = "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*";
            OpenDialog.RestoreDirectory = true;
            OpenDialog.Title = Title;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                return OpenDialog.FileName;
            }

            return "";
        }

        // CFG files (*.cfg)|*.cfg|All files (*.*)|*.*
        public static string[] LoadCFG()
        {

            string FilePath = GetFilePath(CSGODirectory, "CFG files (*.cfg)|*.cfg|All files (*.*)|*.*", "Load a Configuration file.");
            if (File.Exists(FilePath))
            {
                return File.ReadAllLines(FilePath);
            }
            return new string[0];
        }

    }
}
