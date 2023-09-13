using _100_p4_1;
try
{
    List<int> doll = new List<int>() { 25, 20, 5, 1 };
    List<amount> outdata = new List<amount>();
    string outstring = "";
    foreach (var path in new List<string>() { @".\in1.txt", @".\in2.txt" })
    {
        var count = Enumerable.Repeat(0, 4).ToList();
        foreach (var line in File.ReadLines(path).Skip(1).Select(int.Parse))
        {
            int makechange = 100 - line;
            for (int i = 0; i < doll.Count; i++)
            {
                count[i] += makechange / doll[i];
                makechange %= doll[i];
            }
        }
        outdata.Add(new amount { doll25 = count[0], doll20 = count[1], doll5 = count[2], doll1 = count[3] });
    }
    foreach (var item in outdata)
        outstring += $"25,{item.doll25} 20,{item.doll20} 5,{item.doll5} 1,{item.doll1}\r\n\r\n";
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
}
catch
{
    Console.WriteLine("error");
}
Console.ReadKey();