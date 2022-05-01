using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JSONPackage
{
    public class JSONMethods
    {
        public static void WriteJSONFile(List<String> data, string fileName)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(fileName, json);
            Console.WriteLine($"A file named {fileName} was created with JSON data.");
        }
    }
}
