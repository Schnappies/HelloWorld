using System;

namespace HelloWorld
{
    class Program
    {

        public static string result;

        public static string doSomething()
        {
            result = "Hello World!";
            return "Something";
        }
        static void Main(string[] args)
        {
            //The Global variable is assigned "Hello World!"
            //Thus being access by a Method or any other anywhere the class.
            //The Method is instansiated in main method and thus allows "Hello World!" to be printed.

            //This will add to Git Status and commit as new

            doSomething();
            Console.WriteLine(result);
        }
    }
}
