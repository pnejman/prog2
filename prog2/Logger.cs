using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    //with a logger like that, if an app crashes during execution you get no data logged at all
    class Logger
    {
        public List<LogEntry> Log { get; private set; } = new List<LogEntry>();
        //public string defaultLogPath;
        public string defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.txt");
        public string defaultErrorLogPath;
        private bool giveUp = false;

        public Logger()
        {
            //defaultLogPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.txt");
        }

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
            SaveLog(defaultLogPath, true, new string[] { logEntry.ToString() });
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
