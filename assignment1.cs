using System;

namespace Design_patterns_object_oriented_techniques
{
    class Program
    {
        static void Main(string[] args)
        {
            /// The 'Logger' class can be called from 'Main' method
            Logger logger = Logger.Instance;
            logger.print(args);
            Console.WriteLine("Hello World");
        }

        /// Create a class called 'Logger'
        /// Implement the Singleton pattern to ensure that only one instance of 'Logger' is created
        class Logger
        {
            private Logger() { }
            private static Logger _instance = null;
            public static Logger Instance
            {
                get
                {
                    if (_instance == null) _instance = new Logger();
                    return _instance;
                }
            }
            /// Add public method that takes a string message as an argument
            public void print(String[] args)
            {
                /// The created method should print the message it receives
                Console.WriteLine(args);
            }
        }
    }
}
