using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
  public  class MoodAnalyzeException: Exception
    {
        /// <summary>
        /// exception Enum
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message, NO_SUCH_CLASS, NO_SUCH_METHOD
        }

        ////Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;

        public MoodAnalyzeException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
