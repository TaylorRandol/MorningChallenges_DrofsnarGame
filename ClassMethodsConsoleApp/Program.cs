using ClassMethodsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                                //Creating
                                //New Object
            Greeter bob = new Greeter();

            Greeter jose = new Greeter(true);

            //bob.SayHello();

            //Console.WriteLine("Enter a number");
            //string numberOfString = Console.ReadLine();

            //int number = int.Parse(numberOfString);

            //bob.SayHelloMultipleTimes(number);

            Console.WriteLine("What is my name?");
            string input = Console.ReadLine();

            bob.FirstName = input;

            bob.FormalGreeting();

            Console.WriteLine("What is your name?");
            string input2 = Console.ReadLine();

            bob.YourName = input2;

            bob.Introduction();

            string YesOrNo;

            Console.WriteLine("Would you like to start a quest (1=Yes / 0=No)? ");
            YesOrNo = Console.ReadLine();
            Console.WriteLine(YesOrNo == "1" ? "Yes" : (YesOrNo == "0" ? "No" : "Invalid Answer"));

            //bool confirmed = false;
            //while(!confirmed)
            //{
            //    Console.WriteLine("Would you like to start the quest?");
            //    Console.WriteLine("Yes / No");
            //    string key = Console.ReadLine();
            //    if (key == "yes")
            //    {
            //        confirmed = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Maybe next time.");
            //    }
                
            //}
        }
    }
}
