class LoggingService
{
    private static LoggingService _instance;

    // Object for thread-safe locking
    private static readonly object lockObject = new object();

    private LoggingService()
    {
        
    }

    public static LoggingService getInstance()
    {
        // Double-checked locking to ensure thread safety
        if (_instance == null)
        {
            lock (lockObject)
            {
                if (_instance == null)
                {
                    _instance = new LoggingService();
                }
            }
        }
        return _instance;
    }

    public void showLoggingTime(string message)
    {
        Console.WriteLine($"{DateTime.Now}: {message}");
    }

    public void enterOffice(string personName)
    {
        showLoggingTime($"{personName} entered the UCI office.");
    }

    public static void Main(string[] args)
    {
        LoggingService logger = LoggingService.getInstance();

        logger.enterOffice("Zeel Sathwara");
        logger.enterOffice("XYZ");
    }
}


