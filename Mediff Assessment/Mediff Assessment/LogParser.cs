using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mediff_Assessment
{
    public class LogParser
    {
        public string segregateErrorAndWarningLogs(string filePath)
        {
            if(File.Exists(filePath))
            {
                List<string> errorLogLines = new List<string>();
                string[] logLines = File.ReadAllLines(filePath);
                foreach(string logLine in logLines)
                {
                    if(logLine.Contains("[FATAL]") || logLine.Contains("[ERROR]") || logLine.Contains("[WARN]"))
                    {
                        errorLogLines.Add(logLine);
                    }
                }
                string errorLogFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filePath), "error.log");
                File.WriteAllLines(errorLogFile, errorLogLines);
                return "The output file path is " + errorLogFile;
            }
            else
            {
                return "File Doesn't Exist";
            }
        }
    }
}
