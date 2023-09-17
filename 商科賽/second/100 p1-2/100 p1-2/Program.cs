try
{
    string outstring = "";
    foreach (var path in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(path))
            outstring += (EvaluateExpression(line.Split("==")[0]) == EvaluateExpression(line.Split("==")[1])) + "\r\n";
        outstring += "\r\n";
    }
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
}
catch
{
    Console.WriteLine("error");
}
Console.ReadKey();
static int EvaluateExpression(string expression)
{
    var symbol = Regex.Split(expression, @"([-\+\*])").Where(x => Regex.IsMatch(x, @"[-\+\*]")).ToList();
    var values = Regex.Split(expression, @"([-\+\*])").Where(x => !Regex.IsMatch(x, @"[-\+\*]")).Select(int.Parse).ToList();
    for (int i = 0; i < symbol.Count; i++)
        if (symbol[i] == "*")
        {
            values[i] *= values[i + 1];
            values.RemoveAt(i + 1);
            symbol.RemoveAt(i);
            i--;
        }
    for (int i = 0; i < symbol.Count; i++)
        if (symbol[i] == "+")
            values[0] += values[i + 1];
        else if (symbol[i] == "-")
            values[0] -= values[i + 1];
    return values.First();
}