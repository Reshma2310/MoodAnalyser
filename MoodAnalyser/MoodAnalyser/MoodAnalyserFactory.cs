using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object MoodAnalyserObject(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(pattern, ClassName);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        public static object MoodAnalyzerParameter(string ClassName, string ConstructorName, string message)
        {
            Type type = typeof(MoodAnalyserClass);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "Class not found");                
            }
        }
    }
}
