namespace MoodAnalyserTests
{
    public class Tests
    {
        [Test]
        public void GivenStringMood_AnalyseMood_ReturnSadMood()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass("I'm in Sad mood");
            string actualResult = analyse.Analyse();
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenStringInput_AnalyseMood_ReturnHappy()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass("I'm in Happy mood");
            string actualResult = analyse.Analyse();
            Assert.AreEqual("Happy", actualResult);
        }
        [Test]
        public void GivenInputNull_AnalyseMood_ReturnHappy()
        {
            MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass(null);
            string actualResult = analyse.Analyse();
            Assert.AreEqual("Happy", actualResult);
        }
    }
}