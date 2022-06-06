using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
        public string Analyse(string Mood)
        {
            if (Mood.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}