try
{
    string outstring = "";
    List<string> file = new List<string>() { @".\in1.txt", @".\in2.txt" };
    foreach (var item in file)
    {
        var openfile = File.ReadAllText(item).Replace("，", "").Replace("、", "").Replace("。", "").Replace("\r\n", "").ToCharArray();
        var alltext = openfile.GroupBy(str => str).OrderByDescending(group => group.Count()).Select(x => new { key = x.Key, value = x.Count() });
        var max = alltext.Max(x => x.value);
        foreach (var item1 in alltext.Where(x => x.value == max))
            outstring += $"{item1.key} {item1.value}" + Environment.NewLine;
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