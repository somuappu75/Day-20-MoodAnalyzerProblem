﻿using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Refactror a To intialize parameter
            Console.WriteLine("Exception Handling In  MoodAnalyser Problem");
            Console.WriteLine("--------------Welcome To Mood Analyzer Problem------------");
            MoodAnalyze moodAnalyze = new MoodAnalyze("I am in Happy Mood");
            string mood = moodAnalyze.AnalyzeMood();

            Type type = typeof(MoodAnalyze);
            Console.WriteLine(type.FullName);

        }
    }
}
