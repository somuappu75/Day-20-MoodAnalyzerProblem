using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("Exception Handling In  MoodAnalyser Problem");
            Console.WriteLine("-------Using Reflection 1.Get Methods 2.Get constructor 3.Get Type------ ");
            Console.WriteLine("--------------Welcome To Mood Analyzer Problem------------");
            MoodAnalyze moodAnalyze = new MoodAnalyze("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

            Type type = typeof(MoodAnalyze);
            Console.WriteLine(type.FullName);

        }
    }
}
