using DevProLauncher.Windows.MessageBoxs;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DevProLauncher.Helpers
{
    public static class PicsManager
    {
        public static string AppPath = Application.StartupPath;

        public static void CheckPics()
        {
            if (!Directory.Exists(Path.Combine(AppPath, "pics")))
            {
                if (MessageBox.Show("Pics are missing on your launcher, do you want to install their ?", "Missing pics !", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var updateProcess = new Process
                    {
                        StartInfo =
                            {
                                FileName = Path.Combine(AppPath, "PicsDownloader.exe")
                            }
                    };
                    updateProcess.Start();
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
