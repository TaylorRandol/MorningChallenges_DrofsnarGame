using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sept15th
{
    [TestClass]
    public class Unit1
    {
        [TestMethod]
        public void ChallengeSept15()
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }

            foreach(char letter in word)
            {
                if(letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }
            }

            int count = 0;

            foreach(int letterCount in word)
            {
                count++;
            }
            Console.WriteLine(count);

            foreach(char letter in word)
            {
                if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an l");
                }
            }    

        }
    }
}
