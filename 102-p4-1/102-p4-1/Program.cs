try
{
    List<string> file = new List<string>() { @".\in1.txt", @".\in2.txt" };
    string outstring = "";
    foreach (var item in file)
    {
        var readline = File.ReadAllLines(item);
        foreach (var line in readline.Skip(1).Select(x => x.Replace("-", "")))
        {
            int S = 0; string TF = "";
            if (line.Length == 10)
            {
                for (int i = 10; i >= 2; i--)
                    S += int.Parse(line[10 - i].ToString()) * i;
                var Smod11 = 11 - (S % 11);
                if ((Smod11 == 10 && line.Last() == 'X') || (Smod11 == 11 && line.Last() == '0') || Smod11.ToString() == line.Last().ToString())
                    TF = "T";
                else
                    TF = "F";
            }
            else if (line.Length == 13)
            {
                S = 0;
                for (int i = 0; i < 12; i++)
                    if (i % 2 == 0)
                        S += int.Parse(line[i].ToString());
                    else
                        S += int.Parse(line[i].ToString()) * 3;
                var Smod10 = 10 - (S % 10);
                if ((Smod10 == 10 && line.Last() == 0) || (Smod10.ToString() == line.Last().ToString()))
                    TF = "T";
                else
                    TF = "F";
            }
            outstring += TF + Environment.NewLine;
        }
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