// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
List<string> allowedSigns = ["rock", "paper", "scissors", "lizard", "spock"];
Dictionary<string, List<string>> winningMap = [];
winningMap["rock"] = ["scissors", "lizard"];
winningMap["paper"] = ["rock", "spock"];
winningMap["scissors"] = ["paper", "lizard"];
winningMap["lizard"] = ["paper", "spock"];
winningMap["spock"] = ["rock", "scissors"];

string GetCorrectsign(string playerName)
{   
    Console.WriteLine($"{playerName}, choose your sign ({string.Join('/', allowedSigns)})");
    string sign = Console.ReadLine()!;


    while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{playerName}, choose correct sign({string.Join('/', allowedSigns)})");
        sign = Console.ReadLine()!;
    }
    return sign;
}

string GetCorrectRandomSign(string playerName)
{
    int signIndex = Random.Shared.Next(allowedSigns.Count);
    string sign = allowedSigns[signIndex];
    Console.WriteLine($"{playerName} selected {sign}");

    return sign;
}

const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
int player1Score = 0;
int player2Score = 0;

Console.WriteLine("How many wins?");
string maxWinsText = Console.ReadLine()!;
//int maxWins = int.Parse(maxWinsText);
//int maxWins = Convert.ToInt32(maxWinsText);
bool parsingResult = uint.TryParse(maxWinsText, out uint maxWins);

while (!parsingResult || maxWins <= 0)
{
    maxWinsText = Console.ReadLine()!;
    parsingResult = uint.TryParse(maxWinsText, out maxWins);
}

while (player1Score < maxWins && player2Score < maxWins)
{
    string player1 = GetCorrectsign("Player 1");
    string player2 = GetCorrectsign("Player 2");

    List<string> signsLosingWithFirstSign = winningMap[player1];
    
    if (player1.Equals(player2, stringComparison))
    {
        Console.WriteLine("It's a draw!");
    }
    else if (signsLosingWithFirstSign.Contains(player2, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Player1 won!");
        player1Score += 1;
    }
    else
    {
        Console.WriteLine("Player2 won!");
        player2Score += 1;
    }
        Console.WriteLine($"First player:{player1Score}");
        Console.WriteLine($"Second player:{player2Score}");

    //if (player1Score >= maxWins || player2Score >= maxWins)
    //{
    //    break;     
    //}
}