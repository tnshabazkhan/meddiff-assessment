using System;
using System.Collections.Generic;
using System.Text;

namespace Mediff_Assessment
{
    public class GroupFiles
    {
        public Dictionary<string, List<string>> GroupByOwner(Dictionary<string, string> fileOwnerDictionary)
        {
            Dictionary<string, List<string>> filesByOwnerDictionary = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, string> fileEntry in fileOwnerDictionary)
            {
                if (!filesByOwnerDictionary.ContainsKey(fileEntry.Value))
                {
                    filesByOwnerDictionary[fileEntry.Value] = new List<string>() { fileEntry.Key };
                }
                else
                {
                    filesByOwnerDictionary[fileEntry.Value].Add(fileEntry.Key);
                }
            }
            return filesByOwnerDictionary;
        }
    }
}
