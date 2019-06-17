using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    //with a logger like that, if an app crashes during execution you get no data logged at all
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


    //in general, it is good to have one .cs file per class
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

    //same for enums, one file per class is welcome
    enum ErrorLevel
    {
        Info,
        Error
    }
}
