using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProblem
{
   public class MoodAnalyseFactory
    {
        /// <summary>
        ///  method to create object of MoodAnalyse class.
        /// </summary>
        /// <param name="className">MoodAnalyseFactory</param>
        /// <param name="constructorName">CreateMoodAnalyse</param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnaylseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnaylseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }
        }

        //uc-5 added
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName,string message)
        {
            Type type = typeof(MoodAnalyze);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
                }

            }
            else
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }

        }
        //uc-6 added the excetion handling is created 
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblem.MoodAnalyze");
                object moodAnalyseObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyze", "MoodAnalyze", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzeException(MoodAnalyzeException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }

       
            

    }
 }
    

