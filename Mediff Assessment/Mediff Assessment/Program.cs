
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mediff_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1 - Group files by owner
            Dictionary<string, string> inputDict = new Dictionary<string, string>() { { "Statuc.py", "Stan" }, { "Setup.py", "Bran" }, { "Hello.py", "Stan" }, { "Input.txt", "Randy" }, { "Code.py", "Stan" }, { "Output.txt", "Randy" } };
            GroupFiles groupFiles = new GroupFiles();
            Dictionary<string, List<string>> outputDict = groupFiles.GroupByOwner(inputDict);

            //this loop is just to print the output, not an actual part of the function
            foreach (KeyValuePair<string, List<string>> entry in outputDict)
            {
                Console.WriteLine("Owner = {0}, Files = {1}", entry.Key, "[" + string.Join(", ", entry.Value) + "]");
            }

            //Problem 2 - Palindrome
            Palindrome palindrome = new Palindrome();
            bool result = palindrome.CheckForPalindrom("dabcbad");
            Console.WriteLine("Is Palindrome {0}", result);


            //Problem 3 - Parse Logs for Errors and Warnings
            LogParser logParser = new LogParser();
            string logFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "sample.log");
            string outputFilePath = logParser.segregateErrorAndWarningLogs(logFilePath);
            Console.WriteLine(outputFilePath);

            //Problem 4 - Parse Logs for Errors and Warnings
            Path path = new Path(@"/ABCD/AF/a");
            string resultString;

            resultString = path.cd(@"/My/Folder/../Folder1/Folder2/../Folder3");
            Console.WriteLine(resultString);

            resultString = path.cd(@"../Folder4/Folder5/../Folder6");
            Console.WriteLine(resultString);

            resultString = path.cd(@"Folder7/Folder8/../Folder9");
            Console.WriteLine(resultString);
        } 
    }
}
