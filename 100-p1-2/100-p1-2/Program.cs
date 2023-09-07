using System.Data;
try
{
    List<string> file = new List<string>() { @".\in1.txt", @".\in2.txt" };
    string outstring = "";
    foreach (string path in file)
    {
        foreach (string line in File.ReadLines(path))
        {
            var leftright = line.Split("==").ToList();
            outstring += (match(leftright.First()) == match(leftright.Last())) + Environment.NewLine;
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
double match(string expression)
{
    DataTable tb = new DataTable();
    tb.Columns.Add("expression", typeof(string), expression);
    DataRow row = tb.NewRow();
    tb.Rows.Add(row);
    return double.Parse((string)row["expression"]);
}