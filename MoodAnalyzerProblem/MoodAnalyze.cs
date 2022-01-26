using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
     public class MoodAnalyze
    {
        private string message;
        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }
}
