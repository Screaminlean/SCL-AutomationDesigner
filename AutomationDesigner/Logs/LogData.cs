namespace AutomationDesigner.Logs
{
    public class LogData
    {
        public string Type { get; set; }

        public string Message { get; set; }

        public LogData(string message, string type = LogTypes.Info)
        {
            Type = type;
            Message = message;
        }
    }
}
