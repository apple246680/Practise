try
{
    string outstring = "";
    foreach (var path in new List<string>() { @".\in1.txt", @".\in2.txt" })
    {
        var openfile = File.ReadAllText(path).Replace("，", "").Replace("、", "").Replace("。", "").Replace("\r\n", "").ToCharArray();
        var alltext = openfile
            .GroupBy(x => x)
            .OrderByDescending(X => X.Count())
            .Select(x => new { key = x.Key, value = x.Count() });

        var max = alltext.Max(x => x.value);
        alltext.Where(x => x.value == max).ToList().ForEach(x =>
        {
            outstring += $"{x.key} {x.value}\r\n";
        });
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