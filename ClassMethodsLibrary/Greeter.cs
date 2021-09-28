using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsLibrary
{
    //camelCase thisIsWritenInCamelCase is used for local variables
    //PascalCase ThisIsPascalCase used for Methods and Properties
    public class Greeter
    {
        public Greeter() { }
        public Greeter(bool questionOne)
        {
            QuestionOne = questionOne;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YourName { get; set; }
        public bool QuestionOne { get; set; }

        //Method
        //Use a verb for Name
                     //Method Signature
        public void SayHello()
        {
            Console.WriteLine("Hello, hope you are having a fantastic day!");
        }


        public void SayHelloMultipleTimes(int numberOfTimes)
        {
            for(int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        public void Introduction()
        {
            Console.WriteLine($"Its nice to meet you, {YourName}.");
        }

        public void FormalGreeting()
        {
            Console.WriteLine($"My name is {FirstName}.");
        }

        public void LetsStart()
        {
            Console.WriteLine($"Great! Lets get started {YourName}.");
        }
    }
}
