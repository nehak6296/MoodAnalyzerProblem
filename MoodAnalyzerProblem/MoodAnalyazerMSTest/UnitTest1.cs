using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyazerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenAnyMoodShouldReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I'm in Any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyaseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
    }
}
