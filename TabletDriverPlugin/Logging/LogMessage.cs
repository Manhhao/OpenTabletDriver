using System;

namespace TabletDriverPlugin.Logging
{
    public class LogMessage
    {
        public LogMessage(string group, string message, LogLevel level)
        {
            Time = DateTime.Now;
            Group = group;
            Message = message;
            Level = level;
        }

        public DateTime Time { private set; get; }
        public string Group { private set; get; }
        public string Message { private set; get; }
        public LogLevel Level { private set; get; }
    }
}