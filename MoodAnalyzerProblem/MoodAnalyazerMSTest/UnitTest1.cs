using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
namespace MoodAnalyazerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void Given_SadMood_Should_ReturnSad()
        { 
            //Arrange
            string expected = "SAD";
            string message = "I'm in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyaseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        //TC1.2
        [TestMethod]
        
        public void Given_AnyMood_Should_ReturnHappy()
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
        //TC2.1
        [TestMethod]
        public void GivenNullMood_Should_ReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null ;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyser.AnalyaseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }

        //TC3.1
        [TestMethod]
        public void Given_When_NullMood_Then_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyaseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        //TC3.2
        [TestMethod]
        public void Given_When_EmptyMood_Then_Throw_MoodAnalysisException_indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyaseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
