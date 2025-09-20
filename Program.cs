using system;

namespace dp

{
    // singelton pattern

    class Database
    //Developers use the Singleton Pattern to manage shared resources.
    //  For example,
    //  a database class can implement the Singleton Pattern to ensure:
    //  there is only one connection to the database throughout the application
    {
        private static Database _instance;
        //constructor
        private DataBase() { }
        //method to get the instance
        public static Database getInstance()
        {
            if (_instance == null)
            {
                //create the new and only instance if it doesn't exist
                _instance = new DataBase();
                
            }
            return instance;
        }
    }
    // ===================factory pattern==================
    interface iNotification
    //to create objects without exposing the instantiation logic to the client
    {
        void notifyUser();
    }
    class SMSNotification : iNotification
    {
        public void notifyUser()
        {
            Console.WriteLine("Sending SMS notification");
        }
    }

    class EmailNotification : iNotification
    {
        public void notifyUser()
        {
            Console.WriteLine("Sending Email notification");
        }
    }

    class FactoryNotification
    {
        //factory method to create objects based on the channel type
        public iNotification createNotificationFactory(string channel)
        {
            if (channel == "SMS")
            {
                return new SMSNotification();
            }
            else if (channel == "Email")
            {
                return new EmailNotification();
            }
            else
            {
                throw new ArgumentException("Invalid channel");
            }
        }
    }

    //==================observer pattern==================
    interface IObserver
    {
        void update(string message);
    }
    public class weatherchange
    {

        private List<IObserver> observers = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void notifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.update(message);
            }
        }
    }
    public class DesktopWeatherApp : IObserver
    {
        private string appName;
        public WeatherApp(string name)
        {
            DesktopWeatherApp = name;
        }
        public void update(string message)
        {
            Console.WriteLine($"{appName} received weather update: {message}");
        }
    }
    public class MobileWeatherApp : IObserver
    {
        private string appName;
        public MobileWeatherApp(string name)
        {
            MobileWeatherApp = name;
        }
        public void update(string message)
        {
            Console.WriteLine($"{appName} received weather update: {message}");
        }
    }

    //==============================adapter pattern==============================================//
    interface ITarget
    {
        string getRequest();
    }



    class Adaptee
    {
        public string getSpecificRequest()
        {
            return "Specific request";
        }
    }

    class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string getRequest()
        {
            return _adaptee.getSpecificRequest();
        }
    }


    //==============================end of adapter pattern==============================================//


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
}