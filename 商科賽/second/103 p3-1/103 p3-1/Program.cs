try
{
    string outstring = "";
    foreach (var filePath in new List<string> { @".\in1.txt", @".\in2.txt" })
    {
        foreach (var line in File.ReadAllLines(filePath).Skip(1).ToList())
            outstring += CalculateMaxScore(line.Split(' ').Select(int.Parse).OrderBy(card => card).Select(card => FormatCard(card)).ToList()) + "\r\n";
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
static string FormatCard(int card)
{ 
    return new List<string> { "黑桃", "紅桃", "方塊", "梅花" }[(card - 1) / 13] + " " + Enumerable.Range(1, 13).ToList()[(card - 1) % 13]; 
}
static bool IsStraight(List<string> hand)
{
    var cardValues = hand.Select(card => card.Split(' ')[1]).OrderBy(value => value).ToList();
    if (cardValues.SequenceEqual(new List<string> { "1", "10", "11", "12", "13" }) || cardValues.SequenceEqual(new List<string> { "2", "3", "4", "5", "1" }))
        return true;
    for (int i = 1; i < cardValues.Count; i++)
        if (int.Parse(cardValues[i]) != int.Parse(cardValues[i - 1]) + 1)
            return false;
    return true;
}
static int CalculateScore(List<string> hand)
{
    var cardCounts = new Dictionary<string, int>();
    foreach (var card in hand)
    {
        var cardValue = card.Split(' ')[1];
        if (cardCounts.ContainsKey(cardValue))
            cardCounts[cardValue]++;
        else
            cardCounts[cardValue] = 1;
    }
    var countValues = cardCounts.Values.OrderBy(value => value).ToList();
    if (IsStraightFlush(hand)) return 7;
    if (countValues.SequenceEqual(new[] { 1, 4 })) return 6;
    if (countValues.SequenceEqual(new[] { 2, 3 })) return 5;
    if (IsStraight(hand)) return 4;
    if (countValues.SequenceEqual(new[] { 1, 1, 3 })) return 3;
    if (countValues.SequenceEqual(new[] { 1, 2, 2 })) return 2;
    if (countValues.SequenceEqual(new[] { 1, 1, 1, 2 })) return 1;
    return 0;
}
static bool IsStraightFlush(List<string> hand)
{
    var cardValues = hand.Select(card => card.Split(' ')[1]).OrderBy(value => value).ToArray();
    for (int i = 1; i < cardValues.Length; i++)
        if (int.Parse(cardValues[i]) != int.Parse(cardValues[i - 1]) + 1)
            return false;
    return true;
}
static List<List<string>> GenerateCombinations(List<string> hand)
{
    var combinations = new List<List<string>>();
    void Generate(int start, List<string> currentCombination)
    {
        if (currentCombination.Count == 5)
        {
            combinations.Add(new List<string>(currentCombination));
            return;
        }
        for (int i = start; i < hand.Count; i++)
        {
            currentCombination.Add(hand[i]);
            Generate(i + 1, currentCombination);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
    Generate(0, new List<string>());
    return combinations;
}
static int CalculateMaxScore(List<string> hand)
{
    var maxScore = 0;
    foreach (var combination in GenerateCombinations(hand))
    {
        var score = CalculateScore(combination);
        if (score > maxScore)
            maxScore = score;
    }
    return maxScore;
}