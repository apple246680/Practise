try
{
    string outstring = "";
    foreach (var path in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(path).Skip(1))
            outstring += $"{S10TO16(S2TO10(line))},{S10TO8(S2TO10(line))}\r\n";
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
static int S2TO10(string Number)
{
    int decimalNumber = 0;
    int binaryLength = Number.Length;
    for (int i = 0; i < binaryLength; i++)
        decimalNumber += (Number[binaryLength - i - 1] - '0') * (int)Math.Pow(2, i);
    return decimalNumber;
}
static string S10TO8(int Number)
{
    string octalNumber = "";
    while (Number > 0)
    {
        octalNumber = (Number % 8).ToString() + octalNumber;
        Number /= 8;
    }
    return octalNumber;
}
static string S10TO16(int Number)
{
    string hexNumber = "";
    while (Number > 0)
    {
        int remainder = Number % 16;
        char hexDigit = (remainder < 10) ? (char)(remainder + '0') : (char)(remainder - 10 + 'A');
        hexNumber = hexDigit + hexNumber;
        Number /= 16;
    }
    return hexNumber;
}