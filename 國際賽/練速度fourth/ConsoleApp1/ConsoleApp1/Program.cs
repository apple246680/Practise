List<int> aa = Enumerable.Range(1, 100).OrderBy(x=>Guid.NewGuid()).ToList();
Console.Write(string.Join("\r\n", aa.Select(x => $"ID: {x.ToString("000")}")));
