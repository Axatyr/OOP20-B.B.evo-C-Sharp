using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace src.src
{
    public class IOLeaderboard
    {

        private IOLeaderboard() { }

        public static void PrintInJsonFormat(string filePath, Dictionary<string, int> leaderboard) {

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(leaderboard, options);

            //Print to file
            File.WriteAllText(filePath, jsonString);
        }

        public static Dictionary<string, int> ReadLeaderboardOnJsonFile(string filePath) 
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
        }
    }
}
