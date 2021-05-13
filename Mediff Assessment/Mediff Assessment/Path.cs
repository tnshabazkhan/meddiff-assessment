using System;
using System.Collections.Generic;
using System.Text;

namespace Mediff_Assessment
{
    public class Path
    {
        public string CurrentPath;
        public Path(string path)
        {
            CurrentPath = path;
        }

        public string cd(string changeDirectoryInput)
        {
            string resultString = "";

            if(string.IsNullOrEmpty(changeDirectoryInput))
            {
                return "Invalid file path";
            }

            try
            {

                if (changeDirectoryInput.StartsWith(".."))
                {
                    resultString = CurrentPath.Substring(0, CurrentPath.LastIndexOf("/"));
                    resultString = resultString + changeDirectoryInput.Substring(2);
                }
                else if (!changeDirectoryInput.StartsWith("/"))
                {
                    resultString = CurrentPath + "/" + changeDirectoryInput;
                }
                else
                {
                    resultString = changeDirectoryInput;
                }

                int indexOfParentOperator = resultString.IndexOf("..");

                while (indexOfParentOperator != -1)
                {
                    string tempString = resultString.Substring(0, indexOfParentOperator);
                    resultString = resultString.Substring(0, tempString.Substring(0, tempString.LastIndexOf("/")).LastIndexOf("/")) +
                                            resultString.Substring(indexOfParentOperator + 2);
                    indexOfParentOperator = resultString.IndexOf("..");
                }

                this.CurrentPath = resultString;
            }
            catch(Exception e)
            {
                return "Cannot find the specified path";
            }
            return resultString;
        }
    }
}
