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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
}