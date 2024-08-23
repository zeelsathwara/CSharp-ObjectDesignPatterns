class Singleton
{
    // Private static instance of the class
    private static Singleton _instance;

    // Private constructor to prevent instantiation
    private Singleton() 
    { 

    }

    // Public static method to get the single instance of the class
    public static Singleton getInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public void showMessage()
    {
        Console.WriteLine("Singleton instance is active.");
    }

    public static void Main()
    {
        Singleton instance1 = Singleton.getInstance(); 
        Singleton instance2 = Singleton.getInstance();

        Console.WriteLine("instance1 == instance2 : " + (instance1 == instance2));

        instance1.showMessage();
    }
}

