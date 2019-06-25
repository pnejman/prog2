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

        public string stringToSave;

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
            string chosen_one = Application.OpenForms["Form1"].Controls["groupBox2"].Controls["FormatSelector"].Text; //it took 10h to find a way to get Form1 private values visible in another class

            Log.Add(logEntry);

            switch (chosen_one)
            {
                case "TXT":
                    stringToSave = logEntry.ToString();
                    defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.txt");
                    defaultErrorLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "error_log.txt");
                    break;

                case "CSV":
                    stringToSave = logEntry.ToCSV();
                    defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.csv");
                    defaultErrorLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "error_log.csv");
                    break;

                case "TSV":
                    stringToSave = logEntry.ToTSV();
                    defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.tsv");
                    defaultErrorLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "error_log.tsv");
                    break;
            }

            if (logEntry.ErrorLevel == ErrorLevel.Info)
            {
                SaveLog(defaultLogPath, true, new string[] { stringToSave });
            }
            else if (logEntry.ErrorLevel == ErrorLevel.Error)
            {
                SaveLog(defaultErrorLogPath, true, new string[] { stringToSave });
            }
        }

        public void SaveLog(string logFilePath, bool append, IEnumerable<string> logItems)
        {
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
