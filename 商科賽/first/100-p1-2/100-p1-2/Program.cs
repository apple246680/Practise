try
{
    string outstring = "";
    foreach (var path in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(path))
            outstring += (EvaluateExpression(line.Split("==")[0]) == EvaluateExpression(line.Split("==")[1])) + Environment.NewLine;
        outstring += Environment.NewLine;
    }
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
    Console.ReadKey();
}
catch
{
    Console.WriteLine("error");
}
static int EvaluateExpression(string expression)
{
    var terms = Regex.Split(expression, @"([-\+\*])");
    var symbol = terms.Where(x => Regex.IsMatch(x, @"[-\+\*]")).ToList();
    var values = terms.Where(x => !Regex.IsMatch(x, @"[-\+\*]")).Select(int.Parse).ToList();
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