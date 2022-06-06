namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenStringMood_AnalyseMood_ReturnSadMood()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass();
            string actualResult = analyse.Analyse("I'm in Sad mood");
            Assert.Pass("Sad", actualResult);
        }
        [Test]
        public void GivenStringInput_AnalyseMood_ReturnHappy()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass();
            string actualResult = analyse.Analyse("I'm in Any mood");
            Assert.Pass("Happy", actualResult);
        }
    }
}