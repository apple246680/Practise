try
{
    var s26 = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
    string outdata = "";
    foreach (var path in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(path).Skip(1))
        {
            List<char> list = new List<char>();
            int some = 0;
            for (int i = 1; i <= 9; i++)
                some += (9 - i) * (int.Parse(line[i - 1].ToString()));
            some += int.Parse(line.Last().ToString());
            for (int i = 10; i <= 35; i++)
                if ((some + (int.Parse(i.ToString()[0].ToString())) + ((int.Parse(i.ToString()[1].ToString())) * 9)) % 10 == 0)
                    list.Add(s26[i - 10]);
            outdata += string.Join("", list) + "\r\n";
        }
        outdata += "\r\n";
    }
    File.WriteAllText(@".\out.txt", outdata);
    Console.WriteLine("OK");
}
catch
{
    Console.WriteLine("error");
}
Console.ReadKey();