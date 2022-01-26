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
        /// TC 1.2 Return happy moood 
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void ReturnHappy()
        {
            //Arrange

            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyze moodAnalyze = new MoodAnalyze(message);

            //Act
            string mood = moodAnalyze.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
