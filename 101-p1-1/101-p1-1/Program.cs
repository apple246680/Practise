string[] filesname = { @".\in1.txt", @".\in2.txt" };
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    foreach (string file in filesname)
    {
        var lines = File.ReadAllLines(file).ToList();
        var wordCount = Regex.Matches(File.ReadAllText(file).ToLower(), $@"\b{lines[0].ToLower()}\b", RegexOptions.IgnoreCase).Count;
        var totalWordCount = 0;
        for (int i = 1; i < lines.Count - 1; i++)
        {
            string line = lines[i];
            string[] words = line.Split(new char[] { ' ', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            totalWordCount += words.Length;
        }
        writer.WriteLine($"{wordCount - 1},{totalWordCount}" + Environment.NewLine);
    }
}
Console.WriteLine("OK");
Console.ReadKey();