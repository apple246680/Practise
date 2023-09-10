try
{
    List<string> setdata = new List<string>();
    Console.WriteLine("please input 1,2,3:");
    switch (Console.ReadLine())
    {
        case "1":
            setdata = File.ReadAllLines(@".\in1.txt").ToList();
            break;
        case "2":
            setdata = File.ReadLines(@".\in2.txt").ToList();
            break;
        case "3":
            setdata = File.ReadAllLines(@".\in3.txt").ToList();
            break;
    }
    if (setdata.Count != 0)
    {
        var a1 = setdata[0].Split(' ').ToList();
        var a2 = setdata[1].Split(' ').ToList();
        Console.WriteLine($"count:{a1.Intersect(a2).Distinct().Count()}");
    }
    else
        Console.WriteLine("error");
    Console.ReadKey();
}
catch (Exception)
{
    Console.WriteLine("error");
}