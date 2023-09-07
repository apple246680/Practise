try
{
    List<string> file = new List<string>() { @".\in1.txt", @".\in2.txt" };
    List<int> doll = new List<int>() { 50, 20, 10, 5, 1 };
    List<amount> perfiledata = new List<amount>();
    string outstring = "";
    foreach (var path in file)
    {
        int[] changeCount = new int[5];
        foreach (var line in File.ReadLines(path).Skip(1).Select(int.Parse))
        {
            int makechange = 100 - line;
            for (int i = 0; i < doll.Count; i++)
            {
                changeCount[i] += makechange / doll[i];
                makechange %= doll[i];
            }
        }
        perfiledata.Add(new amount { doll50 = changeCount[0], doll20 = changeCount[1], doll10 = changeCount[2], doll5 = changeCount[3], doll1 = changeCount[4] });
    }
    foreach (var item in perfiledata)
        outstring += $"50,{item.doll50} 20,{item.doll20} 10,{item.doll10} 5,{item.doll5} 1,{item.doll1}{Environment.NewLine}{Environment.NewLine}";
    File.WriteAllText(@".\out.txt", outstring);
    Console.WriteLine("OK");
    Console.ReadKey();
}
catch
{
    Console.WriteLine("error");
}
class amount
{
   public int doll50 {get; set;}
   public int doll20 { get; set; }
   public int doll10 { get; set; }
   public int doll5 { get; set; }
   public int doll1 { get; set; }
}