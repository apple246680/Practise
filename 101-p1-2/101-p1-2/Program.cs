try
{
    string outstring = "";
    foreach (var item in new List<string>() { @".\in1.txt", @".\in2.txt" })
        outstring += string.Join(",", File.ReadAllText(item).Replace("EOF", "").Replace("\r\n", " ").Split(' ', StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x).Select(x => x.Count()).OrderByDescending(x => x).Take(3)) + Environment.NewLine + Environment.NewLine;
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
    Console.ReadKey();
}
catch
{
    Console.WriteLine("error");
}