using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Infrastructure
{
    public static class Logger
    {
        public static void LogError(string message)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "cookbook_log.txt");

            using(StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
