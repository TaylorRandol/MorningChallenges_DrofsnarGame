using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Sept28
{
    

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\ElevenFiftyProjects\MorningChallenges\Sept28\BirdFile\BirdFile.txt";

            if (!File.Exists(path))
            {
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText, encoding: System.Text.Encoding.UTF8);
            }

            string readText = File.ReadAllText(path);
            string[] words = readText.Split(',');

            int index = 1;
            foreach (var word in words)
            {
                System.Console.WriteLine($"{index}. {word}");
                index++;
            }

        }
    }
}
