using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("--------------Welcome To Mood Analyzer Problem------------");
            MoodAnalyze moodAnalyze = new MoodAnalyze("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

        }
    }
}
