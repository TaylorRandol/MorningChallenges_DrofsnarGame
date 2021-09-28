using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReviewSolution
{
    public class MethodHolder
    {
        //Count from 1 to a number
        //if div by 3 say fizz *write to the console*
        //5 say buzz
        //both say fizzbuzz
        //understanding how to build it out is very important
        //majority credit is given if you know frame and not as much actual coding is okay
        public void FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }

        //Takes in a name 
        //returns the number of letters in the name
        public int Number(string name)
        {
            //Count the letters in string name
            int counter = 0;
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
                counter++;
            }
            return counter;
        }

        //Write a method to say how old someone is
        /*public int AgeCalculator(DateTime birthDate)
        {
            TimeSpan span = DateTime.Now - birthDate;
            return span;
        }*/
    }
}
