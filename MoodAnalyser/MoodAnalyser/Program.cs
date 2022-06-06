
Console.WriteLine("Are you sad or happy");
string input = Console.ReadLine();
MoodAnalyser.MoodAnalyserClass analyse = new MoodAnalyser.MoodAnalyserClass(input);
Console.WriteLine(analyse.Analyse());
