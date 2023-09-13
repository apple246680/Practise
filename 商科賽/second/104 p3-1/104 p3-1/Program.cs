try
{
    string outstring = "";
    foreach (var Path in new List<string>() { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(Path).Skip(1))
        {
            int Count = 0;
            foreach (var perchat in Convert.ToString(int.Parse(line), 2))
                if (perchat == '1')
                    Count++;
            outstring += Count + "\r\n";
        }
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