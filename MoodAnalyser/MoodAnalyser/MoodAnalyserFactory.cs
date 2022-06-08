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
        public static object InvokeMoodAnalyser(string mood, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser.MoodAnalyserClass");
                object moodAnalyse = MoodAnalyserFactory.MoodAnalyzerParameter("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass", "Happy");
                MethodInfo method = type.GetMethod(methodName);
                object chkmood = method.Invoke(moodAnalyse, null);
                return chkmood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }
        }
        public static object SetField(string mood, string fieldName)
        {
            try
            {
                MoodAnalyserClass moodAnalyser = new MoodAnalyserClass();
                Type type = typeof(MoodAnalyserClass);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (mood == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood Should not be null");
                }
                field.SetValue(moodAnalyser, mood);
                return moodAnalyser.input;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_FIELD, "Field Not Found");
            }
        }        
    }
}
