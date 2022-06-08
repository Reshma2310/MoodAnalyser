using MoodAnalyser;

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
        /*[Test]
        public void GivenMoodAnalyseClassName_ShouldreturnObject()
        {
            string message = null;
            object expected = new MoodAnalyserClass(message);
            object actual = MoodAnalyserFactory.MoodAnalyserObject("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            expected.Equals(actual);            
        }*/
        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnClassNotFound()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyserClass(message);
                object actual = MoodAnalyserFactory.MoodAnalyserObject("MoodAnalyser.MoodAnalyserCla", "MoodAnalyser.MoodAnalyserClass");
                expected.Equals(actual);
            }
            catch (MoodAnalyser.MoodAnalyserException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnConstructorNotFound()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyserClass(message);
                object actual = MoodAnalyserFactory.MoodAnalyserObject("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserss");
                expected.Equals(actual);
            }
            catch (MoodAnalyser.MoodAnalyserException exp)
            {
                Assert.AreEqual("Constructor is not found", exp.Message);
            }
        }
        [Test]
        public void GivenMoodParameter_MoodParameterConstructor_ReturnParameterConstructor()
        {
            object expected = new MoodAnalyserClass("Happy");
            object value = MoodAnalyserFactory.MoodAnalyzerParameter("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass", "Happy");
            expected.Equals(value);
        }        
    }
}