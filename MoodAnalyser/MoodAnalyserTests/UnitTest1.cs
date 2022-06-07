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
        public void GivenInputNull_AnalyseMoodAndHandleNullException_ReturnNullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass(message);
                string actualResult = analyse.Analyse();
            }
            catch (MoodAnalyser.MoodAnalyserException exc)
            {
                Assert.AreEqual("Mood is null", exc.Message);
            }
        }
        [Test]
        public void GivenEmpty_AnalyzeMood_HandleEmptyException_ReturnEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass(message);
                string actualResult = analyse.Analyse();
            }
            catch (MoodAnalyser.MoodAnalyserException exc)
            {
                Assert.AreEqual("Mood can not be Empty", exc.Message);
            }
        }
    }
}