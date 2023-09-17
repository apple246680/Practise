try
{
    string outstring = "";
    foreach (var path in new List<string>() { @".\in1.txt", @".\in2.txt" })
        outstring += string.Join(",", 
            File.ReadAllText(path)
                .Split(new string[] {" ","EOF","\r\n"}, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(x => x.ToLower())
                .Select(x => x.Count())
                .OrderByDescending(x => x)
                .Take(3)
                ) + "\r\n\r\n";
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
}
catch
{
    Console.WriteLine("error");
}
Console.ReadKey();