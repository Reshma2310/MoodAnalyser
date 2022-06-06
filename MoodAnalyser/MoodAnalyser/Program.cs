MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass();
Console.WriteLine("Are you sad or happy");
string input = Console.ReadLine();
Console.WriteLine(analyse.Analyse(input));
