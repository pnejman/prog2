using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    class Logger
    {
        public List<LogEntry> Log { get; private set; } = new List<LogEntry>();
        public string defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.txt");
        public string defaultErrorLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "error_log.txt");
        private bool giveUp = false;

        public static Form1 import = new Form1(); //create a new instance of the whole Form1 class, just to import single value from single field.
        
        public void LogEvent(string message)
        {
            AddEntry(new LogEntry(ErrorLevel.Info, message));
        }

        public void LogError(string message)
        {
            AddEntry(new LogEntry(ErrorLevel.Error, message));
        }

        private void AddEntry(LogEntry logEntry)
        {
            Log.Add(logEntry);
            if (logEntry.ErrorLevel == ErrorLevel.Info)
            {
                SaveLog(defaultLogPath, true, new string[] { logEntry.ToString() });
            }
            else if (logEntry.ErrorLevel == ErrorLevel.Error)
            {
                SaveLog(defaultErrorLogPath, true, new string[] { logEntry.ToString() });
            }
        }

        public void SaveLog(string logFilePath, bool append, IEnumerable<string> logItems)
        {
            if (import.FileTypeFromForm == "TXT") //yay. can access Form1 fields. Finally.
            {
                MessageBox.Show("Txt");
            }

            try
            {
                giveUp = false;
                if (append)
                {
                    File.AppendAllLines(logFilePath, logItems);
                }
                else
                {
                    File.WriteAllLines(logFilePath, logItems);
                }
            }
            catch
            {
                if (!giveUp)
                {
                    LogError("Error saving log file");
                }
                giveUp = true;
            }
        }
    }
}
