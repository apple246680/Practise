try
{
    string outstring = "";
    foreach (var path in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        var setdata = File.ReadAllLines(path);
        for (int i = 1; i <= setdata.Length/2+1; i+=2) 
            outstring+=$"{setdata[i].Split(' ').Intersect(setdata[i+1].Split(' ')).Distinct().Count()}\r\n";
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