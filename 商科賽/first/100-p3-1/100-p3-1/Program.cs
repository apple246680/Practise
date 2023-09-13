try
{
    var s26 = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
    string outdata = "";
    foreach (var item in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        var file = File.ReadAllLines(item).Skip(1);
        foreach (var item1 in file)
        {
            List<char> list = new List<char>();
            int something = 0;
            for (int i = 1; i <= 9; i++)
                something += (9 - i) * (int.Parse(item1[i - 1].ToString()));
            something += int.Parse(item1.Last().ToString());
            for (int i = 10; i <= 35; i++)
                if ((something + (int.Parse(i.ToString()[0].ToString())) + ((int.Parse(i.ToString()[1].ToString())) * 9)) % 10 == 0)
                    list.Add(s26[i - 10]);
            outdata += string.Join("", list) + Environment.NewLine;
        }
        outdata += Environment.NewLine;
    }
    File.WriteAllText(@".\out.txt", outdata);
    Console.WriteLine("OK");
    Console.ReadKey();
}
catch
{
    Console.WriteLine("error");
}