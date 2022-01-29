using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyze
    {
        //using reflection get method and constuctor type
        public MoodAnalyze() { }
        private string message;
        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        //exception handle using analyzeMood method
        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }
    }
}
