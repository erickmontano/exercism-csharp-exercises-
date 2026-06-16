static class LogLine
{
    //Gets the log line's message
    public static string Message(string logLine) => logLine.Remove(0, logLine.IndexOf(':') + 1).Trim();

    //Gets the log line's log level
    public static string LogLevel(string logLine) => logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - 1).ToLower();

    //Reformats the log line, putting the message first and the log level after it in parentheses
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
