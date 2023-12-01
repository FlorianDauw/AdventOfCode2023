const string inputPath = @$".\Resources\input.txt";
var sum = File.ReadAllLines(inputPath)
    .Sum((line) => {
        var firstDigit = line.FirstOrDefault(c => char.IsDigit(c)).ToString();
        var lastDigit = line.LastOrDefault(c => char.IsDigit(c)).ToString();
        return int.Parse(string.Concat(firstDigit, lastDigit));
    });
Console.WriteLine($"The sum is : {sum}");