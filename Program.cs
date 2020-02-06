using System;

namespace Library_Terminal_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {


            //Class Program -Logic- (Promps, Inputs, Outputs)(If statements, Switch statements)

            Console.WriteLine("Hello, welcome to the Library.");
            DisplayMenu();//Calling the Method
            GetUserInput("Please Make A Selection From Above: ");


        }
        public static void DisplayMenu()
        {
            Console.WriteLine(" [1]: Display All Books \n [2]: Display Books by Author \n [3]: Display Books by Title \n [4]: Check out Book \n [5] Leave Library ");

        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();


        }
    }
}