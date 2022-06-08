using MoodAnalyser;

namespace MoodAnalyserTests
{
    public class Tests
    {
        /*[Test]
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
        [Test]
        public void GivenInvalidClassName_ValidateTheProcess_ReturnClassNotFound()
        {
            try
            {
                object expected = new MoodAnalyserClass("Happy");
                object actual = MoodAnalyser.MoodAnalyserFactory.MoodAnalyzerParameter("MoodAnalyser.MoodAnalyserss", "MoodAnalyserClass", "Happy");
                expected.Equals(actual);
            }
            catch (Exception exep)
            {
                Assert.AreEqual("Class not found", exep.Message);
            }
        }
        [Test]
        public void GivenInvalidConstructorName_AnalysisOfProcess_ReturnConstructorNotFound()
        {
            try
            {
                object expected = new MoodAnalyserClass("Happy");
                object actual = MoodAnalyser.MoodAnalyserFactory.MoodAnalyzerParameter("MoodAnalyser.MoodAnalyserClass", "MoodAnalysers", "Happy");
                expected.Equals(actual);
            }
            catch (Exception exec)
            {
                Assert.AreEqual("Constructor is not found", exec.Message);
            }
        }
        [Test]
        public void GivenHappyIsInput_ShouldReturnHappy_UsinReflection()
        {
            object expected = "Happy";
            object actual = MoodAnalyser.MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Analyse");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperMethodName_NoSuchMethodException_UsingReflector()
        {
            try
            {
                object expected = "Happy";
                object actual = MoodAnalyser.MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Analyse");
                expected.Equals(actual);
            }
            catch (MoodAnalyser.MoodAnalyserException exck)
            {
                Assert.AreEqual("Constructor is not found", exck.Message);
            }
        }
        [Test]
        public void GivenHappyMood_DynamicRefactor_ReturnHappy()
        {
            object result = MoodAnalyser.MoodAnalyserFactory.SetField("Happy", "input");
            Assert.AreEqual("Happy", result);
        }*/
        [Test]
        public void GivenHappyMood_Analyse_ReturnFieldNotFound()
        {
            try
            {
                object result = MoodAnalyser.MoodAnalyserFactory.SetField("Happy", "input");
                Assert.AreEqual("Happy", result);
            }
            catch (Exception exe)
            {
                Assert.AreEqual("Field Not Found", exe.Message);
            }
        }
        [Test]
        public void GivenNullMood_AnalyseProcess_ReturnNullException()
        {
            try
            {
                object result = MoodAnalyser.MoodAnalyserFactory.SetField("Happy", "input");
                Assert.AreEqual("Happy", result);
            }
            catch (Exception exp)
            {
                Assert.AreEqual("Mood Should not be null", exp.Message);
            }
        }
    }
}