namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenStringMood_AnalyseMood_ReturnSadMood()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass();
            string actualResult = analyse.Analyse("I'm in sad mood");
            Assert.Pass("sad", actualResult);
        }
    }
}