try
{
    List<string> inputFilePaths = new List<string>() { @".\in1.txt", @".\in2.txt" };
    string outputData = "";
    foreach (var filePath in inputFilePaths)
    {
        var linesFromFile = File.ReadAllLines(filePath);
        if (1 <= int.Parse(linesFromFile[0]) && int.Parse(linesFromFile[0]) <= 5)
        {
            foreach (var line in linesFromFile.Skip(1))
            {
                int parsedInt = Convert.ToInt32(line);
                if (0 <= parsedInt && parsedInt <= 65535)
                {
                    int bitCount = 0;
                    string binaryRepresentation = Convert.ToString(parsedInt, 2);
                    foreach (var per in binaryRepresentation)
                        if (per == '1')
                            bitCount++;
                    outputData += bitCount + Environment.NewLine;
                }
            }
            outputData += Environment.NewLine;
        }
    }
    File.WriteAllText(@".\out.txt", outputData);
    Console.WriteLine("OK");
    Console.ReadKey();
}
catch
{
    Console.WriteLine("error");
}