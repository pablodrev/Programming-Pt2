using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Configuration;

namespace SnakeGame
{
    static class Scores
    {
        static public void SaveScoreToFile(string path, List<int> scores)
        {
            string json = JsonSerializer.Serialize(scores);
            File.WriteAllText(path, json);
        }
        static public List<int>? ReadScoreFromFile(string path)
        {
            string json = File.ReadAllText(path);
            List<int>? scores = JsonSerializer.Deserialize<List<int>>(json);
            return scores;
        }
    }
}
