using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnalyzeTest
    {
        /// <summary>
        /// TC 1.1 Return Sad To Test case Pass
        /// </summary>
        [TestMethod]
        public void ReturnSad()
        {
            //Arrange 
            string expected = "SAD";
            string message = " I am in Sad Mood";
            MoodAnalyze moodAnalyze= new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
    
        }
        /// <summary>
        /// TC 1.2 & 2.1 Return happy moood 
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void ReturnHappy(string message)
        {
            //Arrange

            string expected = "HAPPY";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        ///  TC 3.1: Given NULL Mood Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void NULL_MOOD_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                 MoodAnalyze moodAnalyze=new MoodAnalyze(message);
                string mood = moodAnalyze.AnalyzeMood();
            }
            catch (MoodAnalyzeException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        /// <summary>
        /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyze moodAnalyze=new MoodAnalyze(message);
                string mood = moodAnalyze.AnalyzeMood();
            }
            catch (MoodAnalyzeException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
