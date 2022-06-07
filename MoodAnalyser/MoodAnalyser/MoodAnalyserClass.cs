using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        string input;
        public MoodAnalyserClass(string input)
        {
            this.input = input;
        }
        public string Analyse()
        {
            try
            {
                if (this.input.Equals(string.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood can not be Empty");
                if (this.input.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood is null");
            }
        }
    }
}