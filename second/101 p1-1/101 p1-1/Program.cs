using System.Text.RegularExpressions;
try
{
    string outstring = "";
    foreach (string file in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        var lines = File.ReadAllLines(file).ToList();
        var count = 0;
        for (int i = 1; i < lines.Count - 1; i++)
        {
            string[] word = lines[i].Split(new char[] { ' ', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            count += word.Length;
        }
        outstring += $"{Regex.Matches(File.ReadAllText(file).ToLower(), $@"\b{lines[0].ToLower()}\b", RegexOptions.IgnoreCase).Count - 1},{count}\r\n\r\n";
    }
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
}
catch
{
    Console.WriteLine("error");
}
Console.ReadKey();