using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    class Logger
    {
        public List<LogEntry> Log { get; private set; } = new List<LogEntry>();

        public void LogEvent(string message)
        {
            Log.Add(new LogEntry(ErrorLevel.Info, message));
        }

        public void LogError(string message)
        {
            Log.Add(new LogEntry(ErrorLevel.Error, message));
        }
    }

    class LogEntry
    {
        public ErrorLevel ErrorLevel { get; private set; }

        private string _message;
        public string Message
        {
            get { return this.ToString(); }
            private set { _message = value; }
        }
        private string Time;

        public LogEntry(ErrorLevel errorLevel, string message)
        {
            Time = DateTime.Now.ToLongTimeString();
            ErrorLevel = errorLevel;
            Message = message;
        }

        public override string ToString()
        {
            return $"{Time}: {_message}";
        }
    }

    enum ErrorLevel
    {
        Info,
        Error
    }
}
