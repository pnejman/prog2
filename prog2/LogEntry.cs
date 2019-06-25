using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    //in general, it is good to have one .cs file per class
    class LogEntry
    {
        public ErrorLevel ErrorLevel { get; private set; }

        public readonly string message;
        public string Message
        {
            get { return this.ToString(); }
        }

        private readonly string time;

        public LogEntry(ErrorLevel errorLevel, string message)
        {
            this.time = DateTime.Now.ToLongTimeString();
            this.ErrorLevel = errorLevel;
            this.message = message;
        }

        public override string ToString()
        {
            return $"{time}: ({(ErrorLevel == ErrorLevel.Error ? "E" : "I")})  {message}";
        }

        public string ToCSV()
        {
            return $"{time},{(ErrorLevel == ErrorLevel.Error ? "E" : "I")},\"{message}\"";
        }

        public string ToTSV()
        {
            return $"{time}\t{(ErrorLevel == ErrorLevel.Error ? "E" : "I")}\t\"{message}\"";
        }

        public string CleanMessage()
        {
            return this.message;
        }
    }
}
